
namespace calismaa
{
    partial class tedarikci_islem
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
			this.btnsil = new System.Windows.Forms.Button();
			this.btnekle = new System.Windows.Forms.Button();
			this.formtemizligi = new System.Windows.Forms.Button();
			this.txtadres = new System.Windows.Forms.RichTextBox();
			this.txtyetkiliad = new System.Windows.Forms.TextBox();
			this.txtmail = new System.Windows.Forms.MaskedTextBox();
			this.txtfirmaadi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grdtedarikciler = new System.Windows.Forms.DataGridView();
			this.btnguncelle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txttel = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdtedarikciler)).BeginInit();
			this.SuspendLayout();
			// 
			// btnsil
			// 
			this.btnsil.Location = new System.Drawing.Point(853, 165);
			this.btnsil.Margin = new System.Windows.Forms.Padding(4);
			this.btnsil.Name = "btnsil";
			this.btnsil.Size = new System.Drawing.Size(100, 28);
			this.btnsil.TabIndex = 26;
			this.btnsil.Text = "Sil";
			this.btnsil.UseVisualStyleBackColor = true;
			this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
			// 
			// btnekle
			// 
			this.btnekle.Location = new System.Drawing.Point(745, 165);
			this.btnekle.Margin = new System.Windows.Forms.Padding(4);
			this.btnekle.Name = "btnekle";
			this.btnekle.Size = new System.Drawing.Size(100, 28);
			this.btnekle.TabIndex = 25;
			this.btnekle.Text = "Ekle";
			this.btnekle.UseVisualStyleBackColor = true;
			this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
			// 
			// formtemizligi
			// 
			this.formtemizligi.Location = new System.Drawing.Point(41, 165);
			this.formtemizligi.Margin = new System.Windows.Forms.Padding(4);
			this.formtemizligi.Name = "formtemizligi";
			this.formtemizligi.Size = new System.Drawing.Size(100, 28);
			this.formtemizligi.TabIndex = 24;
			this.formtemizligi.Text = "Yeni Kayıt";
			this.formtemizligi.UseVisualStyleBackColor = true;
			this.formtemizligi.Click += new System.EventHandler(this.formtemizligi_Click);
			// 
			// txtadres
			// 
			this.txtadres.Location = new System.Drawing.Point(807, 30);
			this.txtadres.Margin = new System.Windows.Forms.Padding(4);
			this.txtadres.Name = "txtadres";
			this.txtadres.Size = new System.Drawing.Size(221, 117);
			this.txtadres.TabIndex = 23;
			this.txtadres.Text = "";
			// 
			// txtyetkiliad
			// 
			this.txtyetkiliad.Location = new System.Drawing.Point(477, 38);
			this.txtyetkiliad.Margin = new System.Windows.Forms.Padding(4);
			this.txtyetkiliad.Name = "txtyetkiliad";
			this.txtyetkiliad.Size = new System.Drawing.Size(179, 22);
			this.txtyetkiliad.TabIndex = 22;
			// 
			// txtmail
			// 
			this.txtmail.Location = new System.Drawing.Point(477, 102);
			this.txtmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtmail.Name = "txtmail";
			this.txtmail.Size = new System.Drawing.Size(179, 22);
			this.txtmail.TabIndex = 20;
			// 
			// txtfirmaadi
			// 
			this.txtfirmaadi.Location = new System.Drawing.Point(121, 38);
			this.txtfirmaadi.Margin = new System.Windows.Forms.Padding(4);
			this.txtfirmaadi.Name = "txtfirmaadi";
			this.txtfirmaadi.Size = new System.Drawing.Size(148, 22);
			this.txtfirmaadi.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(737, 33);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "Adres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "Telefon";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(357, 42);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Yetkili Ad Soyad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(401, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Mail";
			// 
			// grdtedarikciler
			// 
			this.grdtedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdtedarikciler.Location = new System.Drawing.Point(4, 212);
			this.grdtedarikciler.Margin = new System.Windows.Forms.Padding(4);
			this.grdtedarikciler.Name = "grdtedarikciler";
			this.grdtedarikciler.RowHeadersWidth = 51;
			this.grdtedarikciler.Size = new System.Drawing.Size(1057, 336);
			this.grdtedarikciler.TabIndex = 27;
			this.grdtedarikciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtedarikciler_CellClick);
			// 
			// btnguncelle
			// 
			this.btnguncelle.Location = new System.Drawing.Point(961, 165);
			this.btnguncelle.Margin = new System.Windows.Forms.Padding(4);
			this.btnguncelle.Name = "btnguncelle";
			this.btnguncelle.Size = new System.Drawing.Size(100, 28);
			this.btnguncelle.TabIndex = 28;
			this.btnguncelle.Text = "Güncelle";
			this.btnguncelle.UseVisualStyleBackColor = true;
			this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Firma Adı";
			// 
			// txttel
			// 
			this.txttel.Location = new System.Drawing.Point(150, 108);
			this.txttel.Name = "txttel";
			this.txttel.Size = new System.Drawing.Size(100, 22);
			this.txttel.TabIndex = 29;
			// 
			// tedarikci_islem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.txttel);
			this.Controls.Add(this.btnguncelle);
			this.Controls.Add(this.grdtedarikciler);
			this.Controls.Add(this.btnsil);
			this.Controls.Add(this.btnekle);
			this.Controls.Add(this.formtemizligi);
			this.Controls.Add(this.txtadres);
			this.Controls.Add(this.txtyetkiliad);
			this.Controls.Add(this.txtmail);
			this.Controls.Add(this.txtfirmaadi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1085, 601);
			this.MinimumSize = new System.Drawing.Size(1085, 601);
			this.Name = "tedarikci_islem";
			this.Text = "tedarikci_islem";
			this.Load += new System.EventHandler(this.tedarikci_islem_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdtedarikciler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button formtemizligi;
        private System.Windows.Forms.RichTextBox txtadres;
        private System.Windows.Forms.TextBox txtyetkiliad;
        private System.Windows.Forms.MaskedTextBox txtmail;
        private System.Windows.Forms.TextBox txtfirmaadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdtedarikciler;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txttel;
	}
}