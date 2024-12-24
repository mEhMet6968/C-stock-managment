using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
    public partial class kategori_islem : Form
    {
        public kategori_islem()
        {
            InitializeComponent();
        }
		int seciliGrupId = -1;
   
		private void kategori_islem_Load(object sender, EventArgs e)
		{
			kategori kategori = new kategori();

			grdGruplar.DataSource = kategori.kategorilistele();
			grdGruplar.Columns["kategori_id"].HeaderText = "ID";
			grdGruplar.Columns["kategori_id"].Width = 170;

			grdGruplar.Columns["kategori_adi"].HeaderText = "Grup Adı";
			grdGruplar.Columns["kategori_adi"].Width = 375;
		}
		private void FormuTemizle()
		{
			textBox1.Clear();
			grdGruplar.ClearSelection();
			seciliGrupId = -1;

		}
		private void grdGruplar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				seciliGrupId = Convert.ToInt32(grdGruplar.CurrentRow.Cells["kategori_id"].Value.ToString());
				textBox1.Text= grdGruplar.CurrentRow.Cells["kategori_adi"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "cell click işlemi hatası");

			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			kategori kategori = new kategori();
			if (textBox1.TextLength < 2)
			{
				MessageBox.Show("kategori adı çok kısa");
				FormuTemizle();

			}
			else
			{
				kategori.kategoriAdi = textBox1.Text;
				kategori.kategoriekle();
				grdGruplar.DataSource= kategori.kategorilistele();	
				FormuTemizle();

			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (seciliGrupId != -1)
			{
				kategori kategori = new kategori();
				kategori.kategoriId = seciliGrupId;
				kategori.kategorisil();
				grdGruplar.DataSource = kategori.kategorilistele();
				FormuTemizle();

			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (seciliGrupId != -1)
			{
				if (textBox1.TextLength <2)
				{
					MessageBox.Show("Çok kısa olduu");
				}
				else
				{
				kategori kategori= new kategori
				{
					kategoriId = seciliGrupId,
					kategoriAdi=textBox1.Text,
					
				};
					kategori.kategoriguncelle();
					grdGruplar.DataSource = kategori.kategorilistele();
					FormuTemizle();
				
				}
			}
		}

		private void btnYeni_Click(object sender, EventArgs e)
		{
			FormuTemizle();
		}
	}
}
