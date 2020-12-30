namespace kitapwebsite
{
    partial class SepeteEkle
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSepet = new System.Windows.Forms.DataGridView();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.sepetNo = new System.Windows.Forms.Label();
            this.kitapNo = new System.Windows.Forms.Label();
            this.ekleSepet = new System.Windows.Forms.Button();
            this.araSepet = new System.Windows.Forms.Button();
            this.silSepet = new System.Windows.Forms.Button();
            this.güncelleSepet = new System.Windows.Forms.Button();
            this.listeleSepet = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSepet
            // 
            this.dataGridViewSepet.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepet.Location = new System.Drawing.Point(12, 14);
            this.dataGridViewSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewSepet.Name = "dataGridViewSepet";
            this.dataGridViewSepet.RowHeadersWidth = 51;
            this.dataGridViewSepet.RowTemplate.Height = 24;
            this.dataGridViewSepet.Size = new System.Drawing.Size(524, 552);
            this.dataGridViewSepet.TabIndex = 0;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Azure;
            this.text1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.Black;
            this.text1.HideSelection = false;
            this.text1.Location = new System.Drawing.Point(755, 32);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(128, 45);
            this.text1.TabIndex = 1;
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Azure;
            this.text2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(755, 91);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(128, 45);
            this.text2.TabIndex = 2;
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sepetNo
            // 
            this.sepetNo.BackColor = System.Drawing.Color.LightSlateGray;
            this.sepetNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sepetNo.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepetNo.ForeColor = System.Drawing.Color.Black;
            this.sepetNo.Location = new System.Drawing.Point(562, 32);
            this.sepetNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sepetNo.Name = "sepetNo";
            this.sepetNo.Size = new System.Drawing.Size(174, 45);
            this.sepetNo.TabIndex = 4;
            this.sepetNo.Text = "Sepet Numarası";
            this.sepetNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitapNo
            // 
            this.kitapNo.BackColor = System.Drawing.Color.LightSlateGray;
            this.kitapNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kitapNo.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapNo.ForeColor = System.Drawing.Color.Black;
            this.kitapNo.Location = new System.Drawing.Point(562, 91);
            this.kitapNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kitapNo.Name = "kitapNo";
            this.kitapNo.Size = new System.Drawing.Size(174, 45);
            this.kitapNo.TabIndex = 5;
            this.kitapNo.Text = "Kitap Numarası";
            this.kitapNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ekleSepet
            // 
            this.ekleSepet.BackColor = System.Drawing.Color.SlateGray;
            this.ekleSepet.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleSepet.Location = new System.Drawing.Point(562, 238);
            this.ekleSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ekleSepet.Name = "ekleSepet";
            this.ekleSepet.Size = new System.Drawing.Size(308, 45);
            this.ekleSepet.TabIndex = 6;
            this.ekleSepet.Text = "EKLE";
            this.ekleSepet.UseVisualStyleBackColor = false;
            this.ekleSepet.Click += new System.EventHandler(this.ekleSepet_Click);
            // 
            // araSepet
            // 
            this.araSepet.BackColor = System.Drawing.Color.SlateGray;
            this.araSepet.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.araSepet.Location = new System.Drawing.Point(562, 290);
            this.araSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.araSepet.Name = "araSepet";
            this.araSepet.Size = new System.Drawing.Size(308, 45);
            this.araSepet.TabIndex = 7;
            this.araSepet.Text = "ARA";
            this.araSepet.UseVisualStyleBackColor = false;
            this.araSepet.Click += new System.EventHandler(this.araSepet_Click);
            // 
            // silSepet
            // 
            this.silSepet.BackColor = System.Drawing.Color.SlateGray;
            this.silSepet.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silSepet.Location = new System.Drawing.Point(562, 353);
            this.silSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.silSepet.Name = "silSepet";
            this.silSepet.Size = new System.Drawing.Size(308, 45);
            this.silSepet.TabIndex = 8;
            this.silSepet.Text = "SİL";
            this.silSepet.UseVisualStyleBackColor = false;
            this.silSepet.Click += new System.EventHandler(this.silSepet_Click);
            // 
            // güncelleSepet
            // 
            this.güncelleSepet.BackColor = System.Drawing.Color.SlateGray;
            this.güncelleSepet.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.güncelleSepet.Location = new System.Drawing.Point(562, 487);
            this.güncelleSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.güncelleSepet.Name = "güncelleSepet";
            this.güncelleSepet.Size = new System.Drawing.Size(308, 45);
            this.güncelleSepet.TabIndex = 9;
            this.güncelleSepet.Text = "GÜNCELLE";
            this.güncelleSepet.UseVisualStyleBackColor = false;
            this.güncelleSepet.Click += new System.EventHandler(this.güncelleSepet_Click);
            // 
            // listeleSepet
            // 
            this.listeleSepet.BackColor = System.Drawing.Color.SlateGray;
            this.listeleSepet.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleSepet.Location = new System.Drawing.Point(562, 420);
            this.listeleSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listeleSepet.Name = "listeleSepet";
            this.listeleSepet.Size = new System.Drawing.Size(308, 45);
            this.listeleSepet.TabIndex = 10;
            this.listeleSepet.Text = "LİSTELE";
            this.listeleSepet.UseVisualStyleBackColor = false;
            this.listeleSepet.Click += new System.EventHandler(this.listeleSepet_Click);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.LightSlateGray;
            this.ad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ad.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.Color.Black;
            this.ad.Location = new System.Drawing.Point(562, 147);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(174, 45);
            this.ad.TabIndex = 12;
            this.ad.Text = "Kitap Adı";
            this.ad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.Azure;
            this.text3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.ForeColor = System.Drawing.Color.Black;
            this.text3.Location = new System.Drawing.Point(755, 147);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text3.Multiline = true;
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(128, 45);
            this.text3.TabIndex = 11;
            this.text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SepeteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(930, 608);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.listeleSepet);
            this.Controls.Add(this.güncelleSepet);
            this.Controls.Add(this.silSepet);
            this.Controls.Add(this.araSepet);
            this.Controls.Add(this.ekleSepet);
            this.Controls.Add(this.kitapNo);
            this.Controls.Add(this.sepetNo);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.dataGridViewSepet);
            this.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SepeteEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SepeteEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSepet;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label sepetNo;
        private System.Windows.Forms.Label kitapNo;
        private System.Windows.Forms.Button ekleSepet;
        private System.Windows.Forms.Button araSepet;
        private System.Windows.Forms.Button silSepet;
        private System.Windows.Forms.Button güncelleSepet;
        private System.Windows.Forms.Button listeleSepet;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox text3;
    }
}

