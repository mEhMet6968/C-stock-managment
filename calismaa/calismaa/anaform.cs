using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
	public partial class anaform : Form
	{
		private int personelId; // Personel ID'yi saklamak için bir alan
		private int musteriIds;

		public anaform(string personelAd, string yetki, int personelId)
		{
			InitializeComponent();

			this.personelId = personelId;

			// Label'lara bilgileri yazdır
			label1.Text = "Ad: " + personelAd;
			label2.Text = "Yetki: " + yetki;
			if (yetki != "beyaz yaka")
			{
				button2.Enabled = false;  // personel işlemleri butonunu devre dışı bırak
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			tedarikci_islem tedarik = new tedarikci_islem();
			DialogResult result = tedarik.ShowDialog();
			if (result == DialogResult.Cancel)
			{
				// Verileri yeniden listelemek için ilgili metodu çağır
				VerileriYenile();
			}
		}

		private void anaform_Load(object sender, EventArgs e)
		{
			VerileriYenile();

			txtgeneltoplam.Enabled = false;
			try
			{
				// `urun` sınıfından bir nesne oluştur
				urun urunIslemleri = new urun();

				// Ürünleri listele
				DataTable urunlerListesi = urunIslemleri.UrunleriListele();

				// Listeleme başarılıysa, verileri DataGridView'e bağla
				if (urunlerListesi != null)
				{
					grd_urunler.DataSource = urunlerListesi;
				}
				else
				{
					MessageBox.Show("Ürünler listelenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// DataGridView ayarlarını yapılandır
			grd_urunler.AutoGenerateColumns = true; // Otomatik sütun oluşturma
				grd_urunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Satır seçimi
				grd_urunler.MultiSelect = false; // Birden fazla seçim engeli
				grd_urunler.ReadOnly = true; // Sadece okuma modunda
			

		}


		private void button5_Click(object sender, EventArgs e)
		{
			urun_islem tedarik = new urun_islem();
			DialogResult result = tedarik.ShowDialog();
			if (result == DialogResult.Cancel)
			{
				// Verileri yeniden listelemek için ilgili metodu çağır
				VerileriYenile();
			}
		}

		private void anaform_FormClosed(object sender, FormClosedEventArgs e)
		{
			Form1 f= new Form1();
			f.Show();
		}
		private void FormuTemizle()
		{





		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				// grd_urunler'de seçili satırı kontrol et
				if (grd_urunler.SelectedRows.Count > 0)
				{
					// Seçili satırı al
					DataGridViewRow seciliSatir = grd_urunler.SelectedRows[0];

					// Gerekli bilgileri al
					string urunAdi = seciliSatir.Cells["urun_adi"].Value.ToString();
					int kod = Convert.ToInt32(seciliSatir.Cells["urun_kodu"].Value);

					// Satış listesinde aynı ürünün olup olmadığını kontrol et
					bool urunZatenEklenmis = grdSatilacakurunler.Rows
						.Cast<DataGridViewRow>()
						.Any(row => Convert.ToInt32(row.Cells["Kod"].Value) == kod);

					if (urunZatenEklenmis)
					{
						MessageBox.Show("Bu ürün daha önce eklenmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return; // İşlemi durdur
					}

					// Diğer bilgileri al
					int miktar = 1; // Varsayılan miktar 1 olarak eklenebilir
					decimal birimFiyat = Convert.ToDecimal(seciliSatir.Cells["fiyat"].Value);
					decimal toplam = miktar * birimFiyat;

					// Yeni bir satır oluştur ve grdSatilacakurunler DataGridView'ine ekle
					int yeniSatirIndex = grdSatilacakurunler.Rows.Add();
					DataGridViewRow yeniSatir = grdSatilacakurunler.Rows[yeniSatirIndex];
					yeniSatir.Cells["urunadi"].Value = urunAdi;
					yeniSatir.Cells["Miktar"].Value = miktar;
					yeniSatir.Cells["birimfiyat"].Value = birimFiyat;
					yeniSatir.Cells["Toplam"].Value = toplam;
					yeniSatir.Cells["Kod"].Value = kod;

					MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					HesaplamalariGuncelle();
				}
				else
				{
					MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button8_Click(object sender, EventArgs e)
		{

			try
			{
				// grdSatilacakurunler'de seçili satır var mı kontrol et
				if (grdSatilacakurunler.SelectedRows.Count > 0)
				{
					// Kullanıcıya onay penceresi göster
					DialogResult dialogResult = MessageBox.Show(
						"Seçili ürünü silmek istediğinize emin misiniz?",
						"Onay",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (dialogResult == DialogResult.Yes)
					{
						// Seçili satırı kaldır
						foreach (DataGridViewRow seciliSatir in grdSatilacakurunler.SelectedRows)
						{
							if (!seciliSatir.IsNewRow) // Yeni satır olmadığından emin ol
							{
								grdSatilacakurunler.Rows.Remove(seciliSatir);
							}
						}
						HesaplamalariGuncelle();

						MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
		
	
		private void button2_Click(object sender, EventArgs e)
		{
			personel_islem tedarik = new personel_islem();
			DialogResult result = tedarik.ShowDialog();
			if (result == DialogResult.Cancel)
			{
				// Verileri yeniden listelemek için ilgili metodu çağır
				VerileriYenile();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

			musteri_islem tedarik = new musteri_islem();
			DialogResult result = tedarik.ShowDialog();
			if (result == DialogResult.Cancel)
			{
				// Verileri yeniden listelemek için ilgili metodu çağır
				VerileriYenile();
			}

		}
		private void VerileriYenile()
		{
			try
			{
				urun urunIslemleri = new urun();
				DataTable urunlerListesi = urunIslemleri.UrunleriListele();

				if (urunlerListesi != null)
				{
					grd_urunler.DataSource = urunlerListesi;
				}
				else
				{
					MessageBox.Show("Veriler yenilenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}






		private void btn_sec_Click(object sender, EventArgs e)
		{
		
			try
			{
				string musteriNumara = richTextBox3.Text.Trim();
				if (string.IsNullOrEmpty(musteriNumara))
				{
					MessageBox.Show("Lütfen müşteri numarasını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				musteri musteriIslemleri = new musteri();
				var musteriBilgileri = musteriIslemleri.MusteriBilgileriGetir(musteriNumara); // Fonksiyon Tuple döndürüyor

				if (!string.IsNullOrEmpty(musteriBilgileri.MusteriAdi))
				{
					int musteriId = musteriBilgileri.MusteriId; // Seçilen müşterinin ID'si
					string musteriAdi = musteriBilgileri.MusteriAdi; // Seçilen müşterinin adı

					txt_musteri.Text = musteriAdi; // Adı göster
					MessageBox.Show($"Müşteri bilgisi başarıyla getirildi.\n\nMüşteri Adı: {musteriAdi}\nMüşteri ID: {musteriId}",
						"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					musteriIds = musteriId;
				}
				else
				{
					MessageBox.Show("Girilen numaraya ait müşteri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		private void HesaplamalariGuncelle()
		{
			try
			{
				decimal genelToplam = 0;

				foreach (DataGridViewRow satir in grdSatilacakurunler.Rows)
				{
					// Miktar ve birim fiyat değerlerini al
					if (satir.Cells["Miktar"].Value != null && satir.Cells["birimfiyat"].Value != null)
					{
						// Miktar ve birim fiyatın geçerli olup olmadığını kontrol et
						if (int.TryParse(satir.Cells["Miktar"].Value.ToString(), out int miktar) &&
							decimal.TryParse(satir.Cells["birimfiyat"].Value.ToString(), out decimal birimFiyat))
						{
							// Negatif miktarları engelle
							if (miktar < 0)
							{
								MessageBox.Show("Miktar negatif olamaz. Lütfen doğru bir değer girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
								satir.Cells["Miktar"].Value = 1; // Varsayılan miktar olarak 1 atar
								miktar = 1;
							}

							// Toplam fiyatı hesapla ve hücreye yaz
							decimal toplamFiyat = miktar * birimFiyat;
							satir.Cells["Toplam"].Value = toplamFiyat;

							// Genel toplama ekle
							genelToplam += toplamFiyat;
						}
						else
						{
							MessageBox.Show("Geçersiz miktar veya birim fiyat değeri. Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

				// Genel toplamı bir Label, TextBox veya benzer bir kontrol üzerinde göster
				txtgeneltoplam.Text = $"{genelToplam}";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void grdSatilacakurunler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			try
			{
				// Kolon var mı diye kontrol et
				if (grdSatilacakurunler.Columns["Miktar"] != null &&
					e.ColumnIndex == grdSatilacakurunler.Columns["Miktar"].Index)
				{
					DataGridViewRow seciliSatir = grdSatilacakurunler.Rows[e.RowIndex];

					// Satırdaki değerleri kontrol et
					if (seciliSatir.Cells["Kod"].Value != null && seciliSatir.Cells["Miktar"].Value != null &&
						decimal.TryParse(seciliSatir.Cells["birimfiyat"].Value?.ToString(), out decimal birimFiyat) &&
						int.TryParse(seciliSatir.Cells["Miktar"].Value?.ToString(), out int girilenMiktar))
					{
						int urunKodu = Convert.ToInt32(seciliSatir.Cells["Kod"].Value);

						// Stok kontrolü için grd_urunler DataGridView'inden stok bilgisi alınır
						int stokAdedi = 0;
						foreach (DataGridViewRow urunSatiri in grd_urunler.Rows)
						{
							if (urunSatiri.Cells["urun_kodu"].Value != null &&
								int.TryParse(urunSatiri.Cells["urun_kodu"].Value.ToString(), out int mevcutUrunKodu) &&
								mevcutUrunKodu == urunKodu)
							{
								stokAdedi = Convert.ToInt32(urunSatiri.Cells["stok_adedi"].Value);
								break;
							}
						}

						if (girilenMiktar > stokAdedi)
						{
							MessageBox.Show($"Stokta yalnızca {stokAdedi} adet mevcut. Miktar buna göre ayarlandı.",
											"Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							girilenMiktar = stokAdedi;
							seciliSatir.Cells["Miktar"].Value = girilenMiktar; // Miktarı stok adedine göre güncelle
						}

						// Toplam fiyatı hesapla	
						decimal toplamFiyat = girilenMiktar * birimFiyat;
						seciliSatir.Cells["Toplam"].Value = toplamFiyat;

						// Genel toplamı güncelle
						HesaplamalariGuncelle();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		//private satisdetay satisDetayForm; // satisdetay formu için bir referans

		//private void VeriAktar()
		//{
		//	if (satisDetayForm == null || satisDetayForm.IsDisposed)
		//	{
		//		satisDetayForm = new satisdetay();
		//		satisDetayForm.Show();
		//	}

		//	// Örnek personelId değişkeni
		//	 // Bunu kendi uygulamanızdaki personelId kaynağına göre ayarlayın

		//	// Personel ID'yi satisdetay formuna gönder
		//	satisDetayForm.PersonelIdEkle(personelId);

		//	// Geçici olarak verileri saklamak için bir DataTable oluştur
		//	DataTable dt = new DataTable();

		//	foreach (DataGridViewColumn column in grdSatilacakurunler.Columns)
		//	{
		//		Type columnType = column.ValueType ?? typeof(string);
		//		dt.Columns.Add(column.Name, columnType);
		//	}

		//	foreach (DataGridViewRow row in grdSatilacakurunler.Rows)
		//	{
		//		if (!row.IsNewRow)
		//		{
		//			DataRow newRow = dt.NewRow();
		//			foreach (DataGridViewColumn column in grdSatilacakurunler.Columns)
		//			{
		//				newRow[column.Name] = row.Cells[column.Name].Value;
		//			}
		//			dt.Rows.Add(newRow);
		//		}
		//	}

		//	satisDetayForm.VeriYukle(dt);
		//}


		private satisdetay satisDetayForm; // satisdetay form referansı

		private void VeriAktar()
		{
			// Eğer form zaten açık değilse yeni bir form oluştur ve aç
			if (satisDetayForm == null || satisDetayForm.IsDisposed)
			{
				satisDetayForm = new satisdetay();
				satisDetayForm.Show();
			}

			// Verileri gönder
			string not = richTextBox1.Text;
			decimal toplamUcret =decimal.Parse(txtgeneltoplam.Text);
			int musteriId = this.musteriIds;

			satisDetayForm.VeriEkle(personelId, not, toplamUcret, musteriId);

			// grdSatilacakurunler'deki verileri satisDetayForm'a gönder
			DataTable dt = new DataTable();

			foreach (DataGridViewColumn column in grdSatilacakurunler.Columns)
			{
				Type columnType = column.ValueType ?? typeof(string);
				dt.Columns.Add(column.Name, columnType);
			}

			foreach (DataGridViewRow row in grdSatilacakurunler.Rows)
			{
				if (!row.IsNewRow)
				{
					DataRow newRow = dt.NewRow();
					foreach (DataGridViewColumn column in grdSatilacakurunler.Columns)
					{
						newRow[column.Name] = row.Cells[column.Name].Value;
					}
					dt.Rows.Add(newRow);
				}
			}

			satisDetayForm.VeriYukle(dt);
		}




		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				// Gerekli kontroller
				if (string.IsNullOrEmpty(txt_musteri.Text.Trim()))
				{
					MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (grdSatilacakurunler.Rows.Count == 0)
				{
					MessageBox.Show("Satış yapılacak ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrEmpty(richTextBox1.Text.Trim()))
				{
					MessageBox.Show("Lütfen not kısmını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Veri aktarımı ve işlemler
				VeriAktar();
				StoklariGuncelle();
				VerileriYenile();
				Temizlik();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}









		private void StoklariGuncelle()
		{
			try
			{
				// Veritabanı bağlantısı
				string connectionString = "server=localhost;database=db;uid=root;pwd=1234";
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					// grdSatilacakurunler'deki her satır için stok güncelle
					foreach (DataGridViewRow satir in grdSatilacakurunler.Rows)
					{
						if (!satir.IsNewRow) // Yeni boş satırları dikkate alma
						{
							// Ürün kodu ve miktar
							int urunKodu = Convert.ToInt32(satir.Cells["Kod"].Value);
							int miktar = Convert.ToInt32(satir.Cells["Miktar"].Value);

							// SQL Sorgusu
							string query = "UPDATE urunler SET stok_adedi = stok_adedi - @miktar WHERE urun_kodu = @urunKodu";

							using (MySqlCommand command = new MySqlCommand(query, connection))
							{
								// Parametreleri ekle
								command.Parameters.AddWithValue("@miktar", miktar);
								command.Parameters.AddWithValue("@urunKodu", urunKodu);

								// Sorguyu çalıştır
								int etkilenenSatirlar = command.ExecuteNonQuery();

								if (etkilenenSatirlar > 0)
								{
									Console.WriteLine($"Ürün {urunKodu} için stok güncellendi.");
								}
								else
								{
									MessageBox.Show($"Ürün {urunKodu} stok güncelleme başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								}
							}
						}
					}

					MessageBox.Show("Stoklar başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			VerileriYenile();
		}
		private void Temizlik()
		{
			// grdSatilacakurunler içindeki tüm satırları temizle
			grdSatilacakurunler.Rows.Clear();

			// richTextBox3 ve txt_musteri'yi temizle
			richTextBox3.Clear();
			txt_musteri.Clear();

			// richTextBox1 ve txt_geneltoplam'ı temizle
			richTextBox1.Clear();
		}

		private void anaform_MouseHover(object sender, EventArgs e)
		{
			VerileriYenile();
		}
	}
}
