using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace calismaa
{
	public partial class satisdetay : Form
	{
		// Stok güncelleme bilgilerini saklamak için bir liste
		private DataTable eksilenStoklar;

		public satisdetay()
		{
			InitializeComponent();
			eksilenStoklar = new DataTable();
			eksilenStoklar.Columns.Add("UrunKodu", typeof(int));
			eksilenStoklar.Columns.Add("Miktar", typeof(int));
			

		}

		public void VeriYukle(DataTable dt)
		{
			grd_satislar.DataSource = dt; // DataGridView'e DataTable'ı bağla

			// Stokları eksiltirken kaydedelim
			foreach (DataRow row in dt.Rows)
			{
				int urunKodu = Convert.ToInt32(row["Kod"]);
				int miktar = Convert.ToInt32(row["Miktar"]);

				// Eksilen stokları listeye ekle
				eksilenStoklar.Rows.Add(urunKodu, miktar);
			}
		}

		private void iptal_Click(object sender, EventArgs e)
		{
			try
			{
				// Veritabanı bağlantısı
				string connectionString = "server=localhost;database=db;uid=root;pwd=1234";
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					// Eksilen stokları geri ekle
					foreach (DataRow row in eksilenStoklar.Rows)
					{
						int urunKodu = Convert.ToInt32(row["UrunKodu"]);
						int miktar = Convert.ToInt32(row["Miktar"]);

						// SQL sorgusu
						string query = "UPDATE urunler SET stok_adedi = stok_adedi + @miktar WHERE urun_kodu = @urunKodu";

						using (MySqlCommand command = new MySqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@miktar", miktar);
							command.Parameters.AddWithValue("@urunKodu", urunKodu);

							// Sorguyu çalıştır
							command.ExecuteNonQuery();
						}
					}

					MessageBox.Show("Sipariş iptal edildi ve stoklar geri yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Formu kapat
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void satisdetay_FormClosed(object sender, FormClosedEventArgs e)
		{






		}


		int personelIdd;
		string notcuk;
		decimal toplamm;
		int musteriIdd;
		public void VeriEkle(int personelId, string not, decimal toplamUcret, int musteriId)
		{
			// Tablo sütunlarını oluştur
			if (grd_digerseyler.Columns.Count == 0)
			{
				grd_digerseyler.Columns.Add("PersonelId", "Personel ID");
				grd_digerseyler.Columns.Add("Not", "Not");
				grd_digerseyler.Columns.Add("ToplamUcret", "Toplam Ücret");
				grd_digerseyler.Columns.Add("MusteriId", "Müşteri ID");
			}
			personelIdd = personelId;
			notcuk= not;
			toplamm =toplamUcret ;
			musteriIdd = musteriId;
			// Yeni satır ekle
			grd_digerseyler.Rows.Add(personelId, not, toplamUcret, musteriId);

			// Debug için tabloyu kontrol et
			MessageBox.Show($"Personel ID: {personelId}, Not: {not}, Toplam Ücret: {toplamUcret}, Müşteri ID: {musteriId}");
		}

		

		private void satisdetay_Load(object sender, EventArgs e)
		{

		}

	
			private void satisonay_Click(object sender, EventArgs e)
			{
				try
				{
					// Veritabanı bağlantısı
					string connectionString = "server=localhost;database=db;uid=root;pwd=1234";
					using (MySqlConnection connection = new MySqlConnection(connectionString))
					{
						connection.Open();

						// Grid'deki her satırı işle
						foreach (DataGridViewRow row in grd_digerseyler.Rows)
						{
							if (!row.IsNewRow) // Yeni satırı hariç tut
							{
								// Değişkenlerden verileri al
								int personelId = personelIdd; // Daha önce kaydedilen değer
								string not = notcuk;         // Daha önce kaydedilen değer
								decimal toplamUcret = toplamm; // Daha önce kaydedilen değer
								int musteriId = musteriIdd;  // Daha önce kaydedilen değer

								// SQL INSERT sorgusu
								string query = @"INSERT INTO satislar (personel_id, `not`, toplamfiyat, musteri_id) 
                                     VALUES (@personelId, @not, @toplamUcret, @musteriId)";

								using (MySqlCommand command = new MySqlCommand(query, connection))
								{
									// Parametreleri ekle
									command.Parameters.AddWithValue("@personelId", personelId);
									command.Parameters.AddWithValue("@not", not);
									command.Parameters.AddWithValue("@toplamUcret", toplamUcret);
									command.Parameters.AddWithValue("@musteriId", musteriId);

									// Sorguyu çalıştır
									command.ExecuteNonQuery();
								}
							}
						}

						MessageBox.Show("Satışlar başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		private void button1_Click(object sender, EventArgs e)
		{
			listele listele = new listele();
			listele.ShowDialog();
		}
	}

	}

