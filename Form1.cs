using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapwebsite
{
    public partial class SepeteEkle : Form
    {
        public SepeteEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KitapWebSite; user ID=postgres;password=6434");
      
        private void listeleSepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select *from public.\"SepetKitap\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewSepet.DataSource = ds.Tables[0];
            MessageBox.Show("SepetKitap tablosu listelendi.");
            baglanti.Close();

        }



        private void ekleSepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = null;
            sorgu=@"select*from sepeteekle (:sepetId,:kitapId,:kitapAd)";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);

            komut1.Parameters.AddWithValue("sepetId", int.Parse(text1.Text));
            komut1.Parameters.AddWithValue("kitapId", int.Parse(text2.Text));
            komut1.Parameters.AddWithValue("kitapAd", text3.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("Kitap sepetinize eklendi");
            baglanti.Close();
        }

        private void silSepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.\"SepetKitap\" where \"kitapNo\"=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(text2.Text));
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kitap sepetinizden silindi");
            baglanti.Close();


        }

        private void güncelleSepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.\"SepetKitap\" set  \"ad\"=@p2  where \"kitapNo\"=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p2", text3.Text);
            komut3.Parameters.AddWithValue("@p1", int.Parse(text2.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Kitap adı sepetinizde güncellendi");
            baglanti.Close();


        }

        private void araSepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select *from public.\"SepetKitap\" where \"ad\" like'%" + text3.Text + "%' ", baglanti);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(komut4);
            DataSet ds2 = new DataSet();
            data.Fill(ds2);
            dataGridViewSepet.DataSource = ds2.Tables[0];
            MessageBox.Show("Arama sonuçlandı.");
            baglanti.Close();
           
        }

       
    }
}
