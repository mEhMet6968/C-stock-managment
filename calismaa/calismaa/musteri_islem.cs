using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calismaa
{
    public partial class musteri_islem : Form
    {
        public musteri_islem()
        {
            InitializeComponent();
        }
        int secilenmusteri = -1;
		private void musteri_islem_Load(object sender, EventArgs e)
		{
            musteri musteri = new musteri();
            grdmusteri.DataSource = musteri.musterilistele();
			grdmusteri.Columns["id"].HeaderText = "id";
            grdmusteri.Columns["id"].Width = 30;

			grdmusteri.Columns["firma_adi"].HeaderText = "firma adı";
			grdmusteri.Columns["firma_adi"].Width = 150;

			grdmusteri.Columns["ad_soyad"].HeaderText = "ad soyad";
			grdmusteri.Columns["ad_soyad"].Width = 120;

			grdmusteri.Columns["telefon"].HeaderText = "telefon";
			grdmusteri.Columns["telefon"].Width = 100;

			grdmusteri.Columns["mail"].HeaderText = "Mail";
			grdmusteri.Columns["mail"].Width = 100;


grdmusteri.Columns["adres"].HeaderText = "Adres";
			grdmusteri.Columns["adres"].Width = 240;
		}
		private void Temizlikzamani()
        {
            txt_adres.Clear();
            txt_adsoyad.Clear();
            txt_firmaadi.Clear();
            txt_mail.Clear();
            txt_tel.Clear();
            grdmusteri.ClearSelection();
            secilenmusteri = -1;
		}
		private bool MusteriGirdiKontrol()
		{
			if (txt_adsoyad.TextLength < 2)
			{
				MessageBox.Show("Yetkili adı en az 2 karakter olmalıdır.");
				return false;
			}
			if (!long.TryParse(txt_tel.Text, out long tel) || txt_tel.TextLength != 11)
			{
				MessageBox.Show("Telefon numarası 11 basamaklı bir sayı olmalıdır.");
				return false;
			}
			if (txt_mail.TextLength < 3)
			{
				MessageBox.Show("E-posta adresi en az 3 karakter olmalıdır.");
				return false;
			}
			if (txt_firmaadi.TextLength < 3)
			{
				MessageBox.Show("Firma adı en az 3 karakter olmalıdır.");
				return false;
			}
			if (txt_adres.TextLength < 5)
			{
				MessageBox.Show("Adres en az 5 karakter olmalıdır.");
				return false;
			}

			// Tüm kontroller geçerli
			return true;
		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			if (!MusteriGirdiKontrol())
			{
				return; // Kontrol başarısızsa işlemi durdur
			}

			try
			{
				musteri musteri = new musteri
				{
					musterifirmaadi = txt_firmaadi.Text,
					musteriadres = txt_adres.Text,
					musterimail = txt_mail.Text,
					musteriyetkiliad = txt_adsoyad.Text,
					musteritel = txt_tel.Text
				};

				musteri.musteriekle();
				grdmusteri.DataSource = musteri.musterilistele();
				Temizlikzamani();
				MessageBox.Show("Müşteri başarıyla eklendi.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}");
			}
		}


		private void btn_sil_Click(object sender, EventArgs e)
		{
			if (secilenmusteri != -1)
			{
				musteri musteri = new musteri();
				musteri.musteriId = secilenmusteri;
				musteri.musterisil();
				grdmusteri.DataSource = musteri.musterilistele();
				Temizlikzamani();

			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (secilenmusteri == -1)
			{
				MessageBox.Show("Lütfen güncellemek için bir müşteri seçiniz.");
				return;
			}

			if (!MusteriGirdiKontrol())
			{
				return; // Kontrol başarısızsa işlemi durdur
			}

			try
			{
				musteri musteri = new musteri
				{
					musteriId = secilenmusteri,
					musteriadres = txt_adres.Text,
					musterifirmaadi = txt_firmaadi.Text,
					musterimail = txt_mail.Text,
					musteritel = txt_tel.Text,
					musteriyetkiliad = txt_adsoyad.Text
				};

				musteri.musteriguncelle();
				grdmusteri.DataSource = musteri.musterilistele();
				Temizlikzamani();
				MessageBox.Show("Müşteri başarıyla güncellendi.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}");
			}
		}


		private void grdmusteri_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				secilenmusteri = Convert.ToInt32(grdmusteri.CurrentRow.Cells["id"].Value.ToString());
				txt_adsoyad.Text = grdmusteri.CurrentRow.Cells["ad_soyad"].Value.ToString();
				txt_adres.Text = grdmusteri.CurrentRow.Cells["adres"].Value.ToString();
				txt_mail.Text = grdmusteri.CurrentRow.Cells["mail"].Value.ToString();
				txt_tel.Text = grdmusteri.CurrentRow.Cells["telefon"].Value.ToString();
				txt_firmaadi.Text = grdmusteri.CurrentRow.Cells["firma_adi"].Value.ToString();


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "cell click işlemi hatası");

			}
		}

		private void btn_yenikayıt_Click(object sender, EventArgs e)
		{
			Temizlikzamani();
		}
	}
}
