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
    public partial class urun_islem : Form
    {
        public urun_islem()
        {
            InitializeComponent();
        }

		int seciliurun = -1;
		
		private void urun_islem_Load(object sender, EventArgs e)
		{
			//combobox kodları
			kategori kategori = new kategori();
			combobox_kategori.DataSource = kategori.kategorilistele();
			combobox_kategori.ValueMember = "kategori_id";
			combobox_kategori.DisplayMember = "kategori_adi";
			DataTable arakategoriDt = kategori.kategorilistele();
			DataRow dr = arakategoriDt.NewRow();
			dr["kategori_adi"] = "Tümü";
			dr["kategori_id"] = 0;
			arakategoriDt.Rows.Add(dr);

			//combobox kodları
			tedarikci tedarikci = new tedarikci();
			combobox_tedarikci.DataSource = tedarikci.TedarikciListele();
			combobox_tedarikci.ValueMember = "id";
			combobox_tedarikci.DisplayMember = "firma_adi";
			DataTable arakategoriDtt = tedarikci.TedarikciListele();
			DataRow drr = arakategoriDtt.NewRow();
			drr["firma_adi"] = "Tümü";
			drr["id"] = 0;
			arakategoriDtt.Rows.Add(drr);
			combobox_tedarikci.SelectedValue = 1;
			combobox_kategori.SelectedValue = 1;

			urun urun = new urun();
			grdurun.DataSource = urun.UrunleriListele();
			grdurun.Columns["urun_kodu"].HeaderText = "Urun kodu";
			grdurun.Columns["urun_kodu"].Width = 90;

			grdurun.Columns["urun_adi"].HeaderText = "Urun Adı";
			grdurun.Columns["urun_adi"].Width = 120;

			grdurun.Columns["stok_adedi"].HeaderText = "Stok adedi";
			grdurun.Columns["stok_adedi"].Width = 90;

			grdurun.Columns["fiyat"].HeaderText = "Fiyat";
			grdurun.Columns["fiyat"].Width = 60;

			grdurun.Columns["id"].HeaderText = "tedarikci";
			grdurun.Columns["id"].Width = 80;

			grdurun.Columns["aciklama"].HeaderText = "Açıklama";
			grdurun.Columns["aciklama"].Width = 200;


		}

		private void btn_yenikayıt_Click(object sender, EventArgs e)
		{
			FormTemizle();
		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			// Girdiler kontrol edilmeden işleme devam edilmez
			if (!KayitKontrol())
			{
				return;
			}

			try
			{
				urun urun = new urun
				{
					urun_adi = txt_urunadi.Text,
					aciklama = txt_aciklama.Text,
					stok_adedi = Int32.Parse(domainupdown_stokadet.Text),
					fiyat = Int32.Parse(txt_fiyat.Text),
					tedarikci_id = Int32.Parse(combobox_tedarikci.SelectedValue.ToString()),
					kategori_id = Int32.Parse(combobox_kategori.SelectedValue.ToString())
				};

				urun.UrunEkle();
				grdurun.DataSource = urun.UrunleriListele();
				FormTemizle();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}");
			}
		}

		private bool KayitKontrol()
		{
			if (txt_aciklama.TextLength < 2)
			{
				MessageBox.Show("Açıklama en az 2 karakter olmalıdır.");
				return false;
			}
			if (txt_fiyat.TextLength < 1 || !int.TryParse(txt_fiyat.Text, out _))
			{
				MessageBox.Show("Geçerli bir fiyat giriniz.");
				return false;
			}
			if (txt_urunadi.TextLength < 2)
			{
				MessageBox.Show("Ürün adı en az 2 karakter olmalıdır.");
				return false;
			}
			if (combobox_kategori.SelectedIndex < 0)
			{
				MessageBox.Show("Lütfen bir kategori seçiniz.");
				return false;
			}
			if (combobox_tedarikci.SelectedIndex < 0)
			{
				MessageBox.Show("Lütfen bir tedarikçi seçiniz.");
				return false;
			}

			// Tüm kontroller başarılıysa true döndür
			return true;
		}

		private void btn_sil_Click(object sender, EventArgs e)
		{
			if (seciliurun != -1)
			{
				urun urunn = new urun();
				urunn.urun_kodu = seciliurun;
				urunn.UrunSil();
				grdurun.DataSource = urunn.UrunleriListele();
				FormTemizle();

			}
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{
			// Eğer güncellenecek ürün seçilmemişse işlem durdurulur.
			if (seciliurun == -1)
			{
				MessageBox.Show("Lütfen güncellemek için bir ürün seçiniz.");
				return;
			}

			// Girdi kontrolünden geçmezse işlem durdurulur.
			if (!KayitKontrol())
			{
				return;
			}

			try
			{
				// Ürün bilgileri güncelleniyor.
				urun urun = new urun
				{
					urun_kodu = seciliurun,
					urun_adi = txt_urunadi.Text,
					stok_adedi = Int32.Parse(domainupdown_stokadet.Text),
					aciklama = txt_aciklama.Text,
					fiyat = Convert.ToDecimal(txt_fiyat.Text), // Fiyat decimal olarak alınıyor.
					kategori_id = Int32.Parse(combobox_kategori.SelectedValue.ToString()),
					tedarikci_id = Int32.Parse(combobox_tedarikci.SelectedValue.ToString())
				};

				urun.UrunGuncelle();

				// Güncellenmiş ürün listesini yeniden yükle
				grdurun.DataSource = urun.UrunleriListele();

				// Form alanlarını temizle
				FormTemizle();

				MessageBox.Show("Ürün başarıyla güncellendi.");
			}
			catch (FormatException ex)
			{
				MessageBox.Show($"Veri formatında hata var: {ex.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}");
			}
		}

		private void grdurun_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (grdurun.SelectedRows != null)
				{
					kategori kategori = new kategori();

					seciliurun = Convert.ToInt32(grdurun.CurrentRow.Cells["urun_kodu"].Value.ToString());
					txt_aciklama.Text = grdurun.CurrentRow.Cells["aciklama"].Value.ToString();

					
					txt_urunadi.Text = grdurun.CurrentRow.Cells["urun_adi"].Value.ToString();
					txt_fiyat.Text = grdurun.CurrentRow.Cells["fiyat"].Value.ToString();
					int kategoriId = Convert.ToInt32(grdurun.CurrentRow.Cells["kategori_id"].Value);
					int tedarikciId = Convert.ToInt32(grdurun.CurrentRow.Cells["id"].Value);

					// ComboBox'lara kategori ve tedarikçi adını ayarla
					combobox_kategori.SelectedValue = kategoriId;
					combobox_tedarikci.SelectedValue = tedarikciId;
					domainupdown_stokadet.Text = grdurun.CurrentRow.Cells["stok_adedi"].Value.ToString();
				}



			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "cell click işlemi hatası");

			}
		}
		private void FormTemizle()
		{
			txt_aciklama.Clear();
			txt_fiyat.Clear();
			txt_urunadi.Clear();
			grdurun.ClearSelection();
			seciliurun = -1;

		}
	}
}
