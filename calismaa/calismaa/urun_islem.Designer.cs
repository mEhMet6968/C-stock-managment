
namespace calismaa
{
    partial class urun_islem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.grdurun = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_urunadi = new System.Windows.Forms.TextBox();
			this.txt_fiyat = new System.Windows.Forms.TextBox();
			this.combobox_kategori = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_aciklama = new System.Windows.Forms.RichTextBox();
			this.btn_yenikayıt = new System.Windows.Forms.Button();
			this.btn_ekle = new System.Windows.Forms.Button();
			this.btn_sil = new System.Windows.Forms.Button();
			this.combobox_tedarikci = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_guncelle = new System.Windows.Forms.Button();
			this.domainupdown_stokadet = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdurun)).BeginInit();
			this.SuspendLayout();
			// 
			// grdurun
			// 
			this.grdurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdurun.Location = new System.Drawing.Point(1, 172);
			this.grdurun.Margin = new System.Windows.Forms.Padding(4);
			this.grdurun.Name = "grdurun";
			this.grdurun.RowHeadersWidth = 51;
			this.grdurun.Size = new System.Drawing.Size(1064, 383);
			this.grdurun.TabIndex = 0;
			this.grdurun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdurun_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ürün Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(349, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Stok Adedi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(367, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Kategori";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 60);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Açıklama";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(752, 96);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Fiyat";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(723, 22);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Tedarikçi";
			// 
			// txt_urunadi
			// 
			this.txt_urunadi.Location = new System.Drawing.Point(101, 12);
			this.txt_urunadi.Margin = new System.Windows.Forms.Padding(4);
			this.txt_urunadi.Name = "txt_urunadi";
			this.txt_urunadi.Size = new System.Drawing.Size(132, 22);
			this.txt_urunadi.TabIndex = 7;
			// 
			// txt_fiyat
			// 
			this.txt_fiyat.Location = new System.Drawing.Point(809, 92);
			this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
			this.txt_fiyat.Name = "txt_fiyat";
			this.txt_fiyat.Size = new System.Drawing.Size(132, 22);
			this.txt_fiyat.TabIndex = 9;
			// 
			// combobox_kategori
			// 
			this.combobox_kategori.FormattingEnabled = true;
			this.combobox_kategori.Location = new System.Drawing.Point(436, 22);
			this.combobox_kategori.Margin = new System.Windows.Forms.Padding(4);
			this.combobox_kategori.Name = "combobox_kategori";
			this.combobox_kategori.Size = new System.Drawing.Size(160, 24);
			this.combobox_kategori.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(605, 23);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 25);
			this.button1.TabIndex = 11;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txt_aciklama
			// 
			this.txt_aciklama.Location = new System.Drawing.Point(101, 57);
			this.txt_aciklama.Margin = new System.Windows.Forms.Padding(4);
			this.txt_aciklama.Name = "txt_aciklama";
			this.txt_aciklama.Size = new System.Drawing.Size(192, 90);
			this.txt_aciklama.TabIndex = 13;
			this.txt_aciklama.Text = "";
			// 
			// btn_yenikayıt
			// 
			this.btn_yenikayıt.Location = new System.Drawing.Point(353, 133);
			this.btn_yenikayıt.Margin = new System.Windows.Forms.Padding(4);
			this.btn_yenikayıt.Name = "btn_yenikayıt";
			this.btn_yenikayıt.Size = new System.Drawing.Size(100, 28);
			this.btn_yenikayıt.TabIndex = 14;
			this.btn_yenikayıt.Text = "Yeni Kayıt";
			this.btn_yenikayıt.UseVisualStyleBackColor = true;
			this.btn_yenikayıt.Click += new System.EventHandler(this.btn_yenikayıt_Click);
			// 
			// btn_ekle
			// 
			this.btn_ekle.Location = new System.Drawing.Point(691, 137);
			this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
			this.btn_ekle.Name = "btn_ekle";
			this.btn_ekle.Size = new System.Drawing.Size(100, 28);
			this.btn_ekle.TabIndex = 15;
			this.btn_ekle.Text = "Ekle";
			this.btn_ekle.UseVisualStyleBackColor = true;
			this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
			// 
			// btn_sil
			// 
			this.btn_sil.Location = new System.Drawing.Point(799, 137);
			this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
			this.btn_sil.Name = "btn_sil";
			this.btn_sil.Size = new System.Drawing.Size(100, 28);
			this.btn_sil.TabIndex = 16;
			this.btn_sil.Text = "Sil";
			this.btn_sil.UseVisualStyleBackColor = true;
			this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
			// 
			// combobox_tedarikci
			// 
			this.combobox_tedarikci.FormattingEnabled = true;
			this.combobox_tedarikci.Location = new System.Drawing.Point(809, 16);
			this.combobox_tedarikci.Margin = new System.Windows.Forms.Padding(4);
			this.combobox_tedarikci.Name = "combobox_tedarikci";
			this.combobox_tedarikci.Size = new System.Drawing.Size(160, 24);
			this.combobox_tedarikci.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(955, 96);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "tl";
			// 
			// btn_guncelle
			// 
			this.btn_guncelle.Location = new System.Drawing.Point(908, 137);
			this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
			this.btn_guncelle.Name = "btn_guncelle";
			this.btn_guncelle.Size = new System.Drawing.Size(100, 28);
			this.btn_guncelle.TabIndex = 19;
			this.btn_guncelle.Text = "Güncelle ";
			this.btn_guncelle.UseVisualStyleBackColor = true;
			this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
			// 
			// domainupdown_stokadet
			// 
			this.domainupdown_stokadet.Location = new System.Drawing.Point(468, 92);
			this.domainupdown_stokadet.Name = "domainupdown_stokadet";
			this.domainupdown_stokadet.Size = new System.Drawing.Size(100, 22);
			this.domainupdown_stokadet.TabIndex = 20;
			// 
			// urun_islem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 554);
			this.Controls.Add(this.domainupdown_stokadet);
			this.Controls.Add(this.btn_guncelle);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.combobox_tedarikci);
			this.Controls.Add(this.btn_sil);
			this.Controls.Add(this.btn_ekle);
			this.Controls.Add(this.btn_yenikayıt);
			this.Controls.Add(this.txt_aciklama);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.combobox_kategori);
			this.Controls.Add(this.txt_fiyat);
			this.Controls.Add(this.txt_urunadi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdurun);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1083, 601);
			this.MinimumSize = new System.Drawing.Size(1083, 601);
			this.Name = "urun_islem";
			this.Text = "urun_islem";
			this.Load += new System.EventHandler(this.urun_islem_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdurun)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdurun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.ComboBox combobox_kategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_aciklama;
        private System.Windows.Forms.Button btn_yenikayıt;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox combobox_tedarikci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guncelle;
		private System.Windows.Forms.TextBox domainupdown_stokadet;
	}
}