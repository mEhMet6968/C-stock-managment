
namespace calismaa
{
    partial class kategori_islem
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
			this.grdGruplar = new System.Windows.Forms.DataGridView();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnYeni = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdGruplar)).BeginInit();
			this.SuspendLayout();
			// 
			// grdGruplar
			// 
			this.grdGruplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdGruplar.Location = new System.Drawing.Point(3, 165);
			this.grdGruplar.Margin = new System.Windows.Forms.Padding(4);
			this.grdGruplar.Name = "grdGruplar";
			this.grdGruplar.RowHeadersWidth = 51;
			this.grdGruplar.Size = new System.Drawing.Size(799, 373);
			this.grdGruplar.TabIndex = 0;
			this.grdGruplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGruplar_CellClick);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(680, 117);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 28);
			this.btnGuncelle.TabIndex = 31;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(572, 117);
			this.btnSil.Margin = new System.Windows.Forms.Padding(4);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 28);
			this.btnSil.TabIndex = 30;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(464, 117);
			this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(100, 28);
			this.btnEkle.TabIndex = 29;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnYeni
			// 
			this.btnYeni.Location = new System.Drawing.Point(680, 26);
			this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
			this.btnYeni.Name = "btnYeni";
			this.btnYeni.Size = new System.Drawing.Size(100, 28);
			this.btnYeni.TabIndex = 32;
			this.btnYeni.Text = "Yeni Kayıt";
			this.btnYeni.UseVisualStyleBackColor = true;
			this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(269, 54);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(248, 22);
			this.textBox1.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 34;
			this.label1.Text = "Kategori Adı";
			// 
			// kategori_islem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 538);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnYeni);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.grdGruplar);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(822, 585);
			this.MinimumSize = new System.Drawing.Size(822, 585);
			this.Name = "kategori_islem";
			this.Text = "kategori_islem";
			this.Load += new System.EventHandler(this.kategori_islem_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdGruplar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGruplar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}