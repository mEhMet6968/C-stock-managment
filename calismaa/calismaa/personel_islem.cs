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
    public partial class personel_islem : Form
    {
        public personel_islem()
        {
            InitializeComponent();
        }
        int secilipersonel = -1;
		private void personel_islem_Load(object sender, EventArgs e)
		{

		
			yetki yetki = new yetki();
			comboBox_yetkiler.DataSource = yetki.yetkilerilistele();
			comboBox_yetkiler.ValueMember = "yetki_id";
			comboBox_yetkiler.DisplayMember = "yetki_adi";
			 

			personel personel = new personel();

			grd_personel.DataSource = personel.personellistele();
			grd_personel.Columns["id"].HeaderText = "id";
			grd_personel.Columns["id"].Width = 30;
			grd_personel.Columns["ad"].HeaderText = "Ad";
			grd_personel.Columns["ad"].Width = 60;

			grd_personel.Columns["soyad"].HeaderText = "Soyad";
			grd_personel.Columns["soyad"].Width = 60;

			grd_personel.Columns["telefon"].HeaderText = "telefon";
			grd_personel.Columns["telefon"].Width = 100;

			grd_personel.Columns["mail"].HeaderText = "Mail";
			grd_personel.Columns["mail"].Width = 140;

			grd_personel.Columns["adres"].HeaderText = "Adres";
			grd_personel.Columns["adres"].Width = 100;

			grd_personel.Columns["kullanici_adi"].HeaderText = "Kullanıcı adı";
			grd_personel.Columns["kullanici_adi"].Width = 55;

			grd_personel.Columns["sifre"].HeaderText = "Şifre";
			grd_personel.Columns["sifre"].Width = 59;

			grd_personel.Columns["yetki_adi"].HeaderText = "Yetki adı";
			grd_personel.Columns["yetki_adi"].Width = 50;


		}

		private void grd_personel_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (grd_personel.SelectedRows != null)
				{
					secilipersonel = Convert.ToInt32(grd_personel.CurrentRow.Cells["id"].Value.ToString());
					txt_ad.Text = grd_personel.CurrentRow.Cells["ad"].Value.ToString();
					txt_soyad.Text = grd_personel.CurrentRow.Cells["soyad"].Value.ToString();
					txt_mail.Text = grd_personel.CurrentRow.Cells["mail"].Value.ToString();
					txt_adres.Text = grd_personel.CurrentRow.Cells["adres"].Value.ToString();
					txt_sifre.Text = grd_personel.CurrentRow.Cells["sifre"].Value.ToString();
					txt_kullaniciadi.Text = grd_personel.CurrentRow.Cells["kullanici_adi"].Value.ToString();
					txt_tel.Text = grd_personel.CurrentRow.Cells["telefon"].Value.ToString();
					comboBox_yetkiler.Text = grd_personel.CurrentRow.Cells["yetki_adi"].Value.ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"cell click hatası");
				throw;
			}
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{
			if (secilipersonel == -1)
			{
				MessageBox.Show("Lütfen güncellenecek personeli seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!KayitKontrol()) return;

			personel personel = new personel
			{
				personelid = secilipersonel,
				personelad = txt_ad.Text,
				personelsoyad = txt_soyad.Text,
				personeltel = txt_tel.Text,
				personelmail = txt_mail.Text,
				personeladres = txt_adres.Text,
				personelkullaniciadi = txt_kullaniciadi.Text,
				personelsifre = txt_sifre.Text,
				yetkiId = Int32.Parse(comboBox_yetkiler.SelectedValue.ToString())
			};

			personel.personelguncelle();
			grd_personel.DataSource = personel.personellistele();
			Temizlik();
		}




		private void btn_sil_Click(object sender, EventArgs e)
		{
			if (secilipersonel != -1)
			{
				personel personel = new personel();
				personel.personelid = secilipersonel;
				personel.personelsil();
				grd_personel.DataSource = personel.personellistele();
				Temizlik();
			}
		}

		private void btn_yenikayit_Click(object sender, EventArgs e)
		{
			Temizlik();
		}
		private void Temizlik()
		{
			txt_ad.Clear();
			txt_adres.Clear();
			txt_kullaniciadi.Clear();
			txt_mail.Clear();
			txt_sifre.Clear();
			txt_soyad.Clear();
			txt_tel.Clear();
			grd_personel.ClearSelection();
			secilipersonel = -1;
		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			if (!KayitKontrol()) return;

			personel personel = new personel
			{
				personelad = txt_ad.Text,
				personelsoyad = txt_soyad.Text,
				personeltel = txt_tel.Text,
				personelmail = txt_mail.Text,
				personeladres = txt_adres.Text,
				personelkullaniciadi = txt_kullaniciadi.Text,
				personelsifre = txt_sifre.Text,
				yetkiId = Int32.Parse(comboBox_yetkiler.SelectedValue.ToString())
			};

			personel.personelekle();
			grd_personel.DataSource = personel.personellistele();
			Temizlik();
		}
		private bool KayitKontrol()
		{
			if (txt_ad.Text.Length < 2)
			{
				MessageBox.Show("Ad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_soyad.Text.Length < 2)
			{
				MessageBox.Show("Soyad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_tel.Text.Length != 11)
			{
				MessageBox.Show("Telefon numarası 11 karakter uzunluğunda olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_mail.Text.Length < 5)
			{
				MessageBox.Show("Mail en az 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_adres.Text.Length < 5)
			{
				MessageBox.Show("Adres en az 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_kullaniciadi.Text.Length < 2)
			{
				MessageBox.Show("Kullanıcı adı en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txt_sifre.Text.Length < 5)
			{
				MessageBox.Show("Şifre en az 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btn_yetkiekle_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yeni yetkiler database aracılığla eklenecektir");
		}
	}
}
