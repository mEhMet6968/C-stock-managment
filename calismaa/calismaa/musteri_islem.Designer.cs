
namespace calismaa
{
    partial class musteri_islem
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
			this.grdmusteri = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_adsoyad = new System.Windows.Forms.TextBox();
			this.txt_firmaadi = new System.Windows.Forms.TextBox();
			this.txt_adres = new System.Windows.Forms.RichTextBox();
			this.btn_yenikayıt = new System.Windows.Forms.Button();
			this.btn_ekle = new System.Windows.Forms.Button();
			this.btn_sil = new System.Windows.Forms.Button();
			this.txt_tel = new System.Windows.Forms.TextBox();
			this.txt_mail = new System.Windows.Forms.TextBox();
			this.btn_update = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdmusteri)).BeginInit();
			this.SuspendLayout();
			// 
			// grdmusteri
			// 
			this.grdmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdmusteri.Location = new System.Drawing.Point(3, 198);
			this.grdmusteri.Margin = new System.Windows.Forms.Padding(4);
			this.grdmusteri.Name = "grdmusteri";
			this.grdmusteri.RowHeadersWidth = 51;
			this.grdmusteri.Size = new System.Drawing.Size(1063, 353);
			this.grdmusteri.TabIndex = 0;
			this.grdmusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdmusteri_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ad Soyad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(389, 94);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(357, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Firma Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 94);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Telefon";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(725, 16);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Adres";
			// 
			// txt_adsoyad
			// 
			this.txt_adsoyad.Location = new System.Drawing.Point(109, 21);
			this.txt_adsoyad.Margin = new System.Windows.Forms.Padding(4);
			this.txt_adsoyad.Name = "txt_adsoyad";
			this.txt_adsoyad.Size = new System.Drawing.Size(148, 22);
			this.txt_adsoyad.TabIndex = 6;
			// 
			// txt_firmaadi
			// 
			this.txt_firmaadi.Location = new System.Drawing.Point(465, 21);
			this.txt_firmaadi.Margin = new System.Windows.Forms.Padding(4);
			this.txt_firmaadi.Name = "txt_firmaadi";
			this.txt_firmaadi.Size = new System.Drawing.Size(193, 22);
			this.txt_firmaadi.TabIndex = 9;
			// 
			// txt_adres
			// 
			this.txt_adres.Location = new System.Drawing.Point(795, 12);
			this.txt_adres.Margin = new System.Windows.Forms.Padding(4);
			this.txt_adres.Name = "txt_adres";
			this.txt_adres.Size = new System.Drawing.Size(221, 117);
			this.txt_adres.TabIndex = 10;
			this.txt_adres.Text = "";
			// 
			// btn_yenikayıt
			// 
			this.btn_yenikayıt.Location = new System.Drawing.Point(29, 148);
			this.btn_yenikayıt.Margin = new System.Windows.Forms.Padding(4);
			this.btn_yenikayıt.Name = "btn_yenikayıt";
			this.btn_yenikayıt.Size = new System.Drawing.Size(100, 28);
			this.btn_yenikayıt.TabIndex = 11;
			this.btn_yenikayıt.Text = "Yeni Kayıt";
			this.btn_yenikayıt.UseVisualStyleBackColor = true;
			this.btn_yenikayıt.Click += new System.EventHandler(this.btn_yenikayıt_Click);
			// 
			// btn_ekle
			// 
			this.btn_ekle.Location = new System.Drawing.Point(753, 150);
			this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
			this.btn_ekle.Name = "btn_ekle";
			this.btn_ekle.Size = new System.Drawing.Size(100, 28);
			this.btn_ekle.TabIndex = 12;
			this.btn_ekle.Text = "Ekle";
			this.btn_ekle.UseVisualStyleBackColor = true;
			this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
			// 
			// btn_sil
			// 
			this.btn_sil.Location = new System.Drawing.Point(954, 148);
			this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
			this.btn_sil.Name = "btn_sil";
			this.btn_sil.Size = new System.Drawing.Size(100, 28);
			this.btn_sil.TabIndex = 13;
			this.btn_sil.Text = "Sil";
			this.btn_sil.UseVisualStyleBackColor = true;
			this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
			// 
			// txt_tel
			// 
			this.txt_tel.Location = new System.Drawing.Point(109, 94);
			this.txt_tel.Name = "txt_tel";
			this.txt_tel.Size = new System.Drawing.Size(148, 22);
			this.txt_tel.TabIndex = 14;
			// 
			// txt_mail
			// 
			this.txt_mail.Location = new System.Drawing.Point(465, 94);
			this.txt_mail.Name = "txt_mail";
			this.txt_mail.Size = new System.Drawing.Size(193, 22);
			this.txt_mail.TabIndex = 15;
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(860, 148);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(87, 30);
			this.btn_update.TabIndex = 16;
			this.btn_update.Text = "güncelle";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// musteri_islem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.txt_mail);
			this.Controls.Add(this.txt_tel);
			this.Controls.Add(this.btn_sil);
			this.Controls.Add(this.btn_ekle);
			this.Controls.Add(this.btn_yenikayıt);
			this.Controls.Add(this.txt_adres);
			this.Controls.Add(this.txt_firmaadi);
			this.Controls.Add(this.txt_adsoyad);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdmusteri);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1085, 601);
			this.MinimumSize = new System.Drawing.Size(1085, 601);
			this.Name = "musteri_islem";
			this.Text = "musteri_islem";
			this.Load += new System.EventHandler(this.musteri_islem_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdmusteri)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdmusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_firmaadi;
        private System.Windows.Forms.RichTextBox txt_adres;
        private System.Windows.Forms.Button btn_yenikayıt;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
		private System.Windows.Forms.TextBox txt_tel;
		private System.Windows.Forms.TextBox txt_mail;
		private System.Windows.Forms.Button btn_update;
	}
}