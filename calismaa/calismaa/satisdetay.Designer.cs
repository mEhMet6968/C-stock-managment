namespace calismaa
{
	partial class satisdetay
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
			this.grd_satislar = new System.Windows.Forms.DataGridView();
			this.iptal = new System.Windows.Forms.Button();
			this.satisonay = new System.Windows.Forms.Button();
			this.grd_digerseyler = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grd_satislar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_digerseyler)).BeginInit();
			this.SuspendLayout();
			// 
			// grd_satislar
			// 
			this.grd_satislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_satislar.Location = new System.Drawing.Point(3, 3);
			this.grd_satislar.Name = "grd_satislar";
			this.grd_satislar.RowHeadersWidth = 51;
			this.grd_satislar.RowTemplate.Height = 24;
			this.grd_satislar.Size = new System.Drawing.Size(756, 410);
			this.grd_satislar.TabIndex = 7;
			// 
			// iptal
			// 
			this.iptal.Location = new System.Drawing.Point(787, 317);
			this.iptal.Name = "iptal";
			this.iptal.Size = new System.Drawing.Size(90, 75);
			this.iptal.TabIndex = 8;
			this.iptal.Text = "Satış İptal";
			this.iptal.UseVisualStyleBackColor = true;
			this.iptal.Click += new System.EventHandler(this.iptal_Click);
			// 
			// satisonay
			// 
			this.satisonay.Location = new System.Drawing.Point(883, 317);
			this.satisonay.Name = "satisonay";
			this.satisonay.Size = new System.Drawing.Size(90, 75);
			this.satisonay.TabIndex = 9;
			this.satisonay.Text = "Satış Onay";
			this.satisonay.UseVisualStyleBackColor = true;
			this.satisonay.Click += new System.EventHandler(this.satisonay_Click);
			// 
			// grd_digerseyler
			// 
			this.grd_digerseyler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_digerseyler.Location = new System.Drawing.Point(787, 12);
			this.grd_digerseyler.Name = "grd_digerseyler";
			this.grd_digerseyler.RowHeadersWidth = 51;
			this.grd_digerseyler.RowTemplate.Height = 24;
			this.grd_digerseyler.Size = new System.Drawing.Size(379, 264);
			this.grd_digerseyler.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(979, 317);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 75);
			this.button1.TabIndex = 11;
			this.button1.Text = "Satış Listesi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// satisdetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 415);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.grd_digerseyler);
			this.Controls.Add(this.satisonay);
			this.Controls.Add(this.iptal);
			this.Controls.Add(this.grd_satislar);
			this.MaximumSize = new System.Drawing.Size(1196, 462);
			this.MinimumSize = new System.Drawing.Size(1196, 462);
			this.Name = "satisdetay";
			this.Text = "satisdetay";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.satisdetay_FormClosed);
			this.Load += new System.EventHandler(this.satisdetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.grd_satislar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_digerseyler)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView grd_satislar;
		private System.Windows.Forms.Button iptal;
		private System.Windows.Forms.Button satisonay;
		private System.Windows.Forms.DataGridView grd_digerseyler;
		private System.Windows.Forms.Button button1;
	}
}