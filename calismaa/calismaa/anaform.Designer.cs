namespace calismaa
{
	partial class anaform
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.grd_urunler = new System.Windows.Forms.DataGridView();
			this.grdSatilacakurunler = new System.Windows.Forms.DataGridView();
			this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtgeneltoplam = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.txt_musteri = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_sec = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdSatilacakurunler)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 77);
			this.button1.TabIndex = 0;
			this.button1.Text = "Tedarikçi İşlemleri";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(375, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 77);
			this.button2.TabIndex = 1;
			this.button2.Text = "Personel İşlemleri";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(254, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 77);
			this.button3.TabIndex = 2;
			this.button3.Text = "Müşteri İşlemleri";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.button5.Location = new System.Drawing.Point(133, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 77);
			this.button5.TabIndex = 4;
			this.button5.Text = "Ürün İşlemleri";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// grd_urunler
			// 
			this.grd_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_urunler.Location = new System.Drawing.Point(12, 95);
			this.grd_urunler.Name = "grd_urunler";
			this.grd_urunler.RowHeadersWidth = 51;
			this.grd_urunler.RowTemplate.Height = 24;
			this.grd_urunler.Size = new System.Drawing.Size(908, 570);
			this.grd_urunler.TabIndex = 5;
			// 
			// grdSatilacakurunler
			// 
			this.grdSatilacakurunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdSatilacakurunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.urunadi,
            this.Miktar,
            this.birimfiyat,
            this.Toplam});
			this.grdSatilacakurunler.Location = new System.Drawing.Point(1024, 177);
			this.grdSatilacakurunler.Name = "grdSatilacakurunler";
			this.grdSatilacakurunler.RowHeadersWidth = 51;
			this.grdSatilacakurunler.RowTemplate.Height = 24;
			this.grdSatilacakurunler.Size = new System.Drawing.Size(372, 308);
			this.grdSatilacakurunler.TabIndex = 6;
			this.grdSatilacakurunler.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSatilacakurunler_CellValueChanged);
			// 
			// Kod
			// 
			this.Kod.HeaderText = "Kod";
			this.Kod.MinimumWidth = 6;
			this.Kod.Name = "Kod";
			this.Kod.ReadOnly = true;
			this.Kod.Width = 35;
			// 
			// urunadi
			// 
			this.urunadi.HeaderText = "Ürün Adı";
			this.urunadi.MinimumWidth = 6;
			this.urunadi.Name = "urunadi";
			this.urunadi.ReadOnly = true;
			this.urunadi.Width = 120;
			// 
			// Miktar
			// 
			this.Miktar.HeaderText = "miktar";
			this.Miktar.MinimumWidth = 6;
			this.Miktar.Name = "Miktar";
			this.Miktar.Width = 50;
			// 
			// birimfiyat
			// 
			this.birimfiyat.HeaderText = "Birim Fiyat";
			this.birimfiyat.MinimumWidth = 6;
			this.birimfiyat.Name = "birimfiyat";
			this.birimfiyat.ReadOnly = true;
			this.birimfiyat.Width = 50;
			// 
			// Toplam
			// 
			this.Toplam.HeaderText = "toplam";
			this.Toplam.MinimumWidth = 6;
			this.Toplam.Name = "Toplam";
			this.Toplam.ReadOnly = true;
			this.Toplam.Width = 60;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(647, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "personel_Adi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(904, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "yetki";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(1064, 510);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(332, 70);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(971, 555);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 25);
			this.label3.TabIndex = 10;
			this.label3.Text = "Not Ekle";
			// 
			// txtgeneltoplam
			// 
			this.txtgeneltoplam.Location = new System.Drawing.Point(1289, 630);
			this.txtgeneltoplam.Name = "txtgeneltoplam";
			this.txtgeneltoplam.Size = new System.Drawing.Size(88, 22);
			this.txtgeneltoplam.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1383, 633);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "tl";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(1172, 633);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Genel Toplam";
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(952, 618);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(136, 41);
			this.button6.TabIndex = 14;
			this.button6.Text = "Satış Yap";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.Location = new System.Drawing.Point(936, 267);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(82, 73);
			this.button7.TabIndex = 15;
			this.button7.Text = "Ekle >>";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button8.Location = new System.Drawing.Point(936, 346);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(82, 73);
			this.button8.TabIndex = 16;
			this.button8.Text = "Sil  <<";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// txt_musteri
			// 
			this.txt_musteri.Location = new System.Drawing.Point(1132, 142);
			this.txt_musteri.Name = "txt_musteri";
			this.txt_musteri.Size = new System.Drawing.Size(245, 29);
			this.txt_musteri.TabIndex = 17;
			this.txt_musteri.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(1132, 95);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(185, 29);
			this.richTextBox3.TabIndex = 18;
			this.richTextBox3.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(1049, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Müşteri";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(992, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(114, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "Müşteri Telefon";
			// 
			// btn_sec
			// 
			this.btn_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_sec.Location = new System.Drawing.Point(1336, 83);
			this.btn_sec.Name = "btn_sec";
			this.btn_sec.Size = new System.Drawing.Size(60, 41);
			this.btn_sec.TabIndex = 21;
			this.btn_sec.Text = "Seç";
			this.btn_sec.UseVisualStyleBackColor = true;
			this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(845, 66);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 22;
			this.button9.Text = "Yenile";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// anaform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1422, 677);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.btn_sec);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.txt_musteri);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtgeneltoplam);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdSatilacakurunler);
			this.Controls.Add(this.grd_urunler);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(1440, 724);
			this.MinimumSize = new System.Drawing.Size(1440, 724);
			this.Name = "anaform";
			this.Text = "anaform";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anaform_FormClosed);
			this.Load += new System.EventHandler(this.anaform_Load);
			this.MouseHover += new System.EventHandler(this.anaform_MouseHover);
			((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdSatilacakurunler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView grd_urunler;
		private System.Windows.Forms.DataGridView grdSatilacakurunler;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtgeneltoplam;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.RichTextBox txt_musteri;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_sec;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
		private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
		private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
		private System.Windows.Forms.Button button9;
	}
}