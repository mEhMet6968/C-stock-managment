using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
    public partial class tedarikci_islem : Form
    {
        public tedarikci_islem()
        {
            InitializeComponent();
        }
		int secilitedarikciid = -1;
		private void grdtedarikciler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				secilitedarikciid = Convert.ToInt32(grdtedarikciler.CurrentRow.Cells["id"].Value.ToString());
				txtadres.Text = grdtedarikciler.CurrentRow.Cells["adres"].Value.ToString();	
				txtfirmaadi.Text = grdtedarikciler.CurrentRow.Cells["firma_adi"].Value.ToString();
				txtmail.Text = grdtedarikciler.CurrentRow.Cells["mail"].Value.ToString();
				txttel.Text = grdtedarikciler.CurrentRow.Cells["telefon"].Value.ToString();
				txtyetkiliad.Text = grdtedarikciler.CurrentRow.Cells["yetkili_adsoyad"].Value.ToString();
				


			}
			catch (Exception ex) 
			{

				MessageBox.Show(ex.Message, "cell click işlemi hatası");

			}
		}

		private void btnekle_Click(object sender, EventArgs e)
		{
			// Eğer girdiler geçerli değilse işlemi durdur
			if (!GirdiKontrol())
			{
				return;
			}

			// Geçerli girdiler varsa ekleme işlemini yap
			tedarikci tedarikci = new tedarikci
			{
				tedarikciadres = txtadres.Text,
				tedarikcifirmaadi = txtfirmaadi.Text,
				tedarikcimail = txtmail.Text,
				tedarikcitel = txttel.Text,
				tedarikciyetkiliadi = txtyetkiliad.Text
			};

			tedarikci.TedarikciEkle();
			grdtedarikciler.DataSource = tedarikci.TedarikciListele();
			FormuTemizle();
		}


		private void btnsil_Click(object sender, EventArgs e)
		{
			if (secilitedarikciid != -1)
			{
				tedarikci tedarikci = new tedarikci();
				tedarikci.tedarikciId = secilitedarikciid;
				tedarikci.TedarikciSil();
				grdtedarikciler.DataSource = tedarikci.TedarikciListele();
				FormuTemizle();
			}
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			if (GirdiKontrol())
			{
				tedarikci tedarikci = new tedarikci
				{
					tedarikciId = secilitedarikciid,
					tedarikcifirmaadi = txtfirmaadi.Text,
					tedarikciadres = txtadres.Text,
					tedarikcimail = txtmail.Text,
					tedarikcitel = txttel.Text,
					tedarikciyetkiliadi = txtyetkiliad.Text

				};


				tedarikci.TedarikciGuncelle();
				grdtedarikciler.DataSource = tedarikci.TedarikciListele();
				FormuTemizle();
			}

			if (secilitedarikciid != -1 )
			{
				if (txtadres.TextLength < 2)
				{
					MessageBox.Show("fazla kısa değer hatası");

				}
				if (txtfirmaadi.TextLength < 2)
				{
					MessageBox.Show("fazla kısa değer hatası");

				}
				if (txtmail.TextLength < 5)
				{
					MessageBox.Show("fazla kısa değer hatası");

				}
				if (txtyetkiliad.TextLength < 2)
				{
					MessageBox.Show("yetkilinin adı 2 harf olamaz");

				}
				if (txttel.TextLength < 11 && txttel.TextLength > 12)
				{
					MessageBox.Show("tel no düzgün girilmeli");

				}

			}
		}

		private void formtemizligi_Click(object sender, EventArgs e)
		{
			FormuTemizle();
		}
		private bool GirdiKontrol()
		{
			// Giriş kontrolleri
			if (txtfirmaadi.TextLength < 2)
			{
				MessageBox.Show("Firma adı en az 2 karakter olmalıdır.");
				return false;
			}
			if (txtadres.TextLength < 5)
			{
				MessageBox.Show("Adres en az 5 karakter olmalıdır.");
				return false;
			}
			if (txtmail.TextLength < 5 || !txtmail.Text.Contains("@"))
			{
				MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
				return false;
			}
			if (txttel.TextLength != 11 || !long.TryParse(txttel.Text, out _))
			{
				MessageBox.Show("Telefon numarası 11 haneli olmalı ve yalnızca sayılardan oluşmalıdır.");
				return false;
			}
			if (txtyetkiliad.TextLength < 2)
			{
				MessageBox.Show("Yetkili adı en az 2 karakter olmalıdır.");
				return false;
			}

			// Tüm kontroller başarılıysa true döndür.
			return true;
		}
		private void FormuTemizle()
		{
			txtadres.Clear();
			txtfirmaadi.Clear();
			txtmail.Clear();
			txttel.Clear();
			txtyetkiliad.Clear();
			grdtedarikciler.ClearSelection();
			secilitedarikciid = -1;
		}

		private void tedarikci_islem_Load(object sender, EventArgs e)
		{
			tedarikci tedarikci = new tedarikci();
			grdtedarikciler.DataSource = tedarikci.TedarikciListele();
			grdtedarikciler.Columns["id"].HeaderText = "ID";
			grdtedarikciler.Columns["id"].Width = 100;

			grdtedarikciler.Columns["firma_adi"].HeaderText = "Firma Adı";
			grdtedarikciler.Columns["firma_adi"].Width = 150;

			grdtedarikciler.Columns["yetkili_adsoyad"].HeaderText = "Yetkili Ad";
			grdtedarikciler.Columns["yetkili_adsoyad"].Width = 80;

			grdtedarikciler.Columns["telefon"].HeaderText = "Telefon";
			grdtedarikciler.Columns["telefon"].Width = 90;

			grdtedarikciler.Columns["mail"].HeaderText = "Mail";
			grdtedarikciler.Columns["mail"].Width = 150;

			grdtedarikciler.Columns["adres"].HeaderText = "Adres";
			grdtedarikciler.Columns["adres"].Width= 170;

		}
	}
}
