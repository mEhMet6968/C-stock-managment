using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace calismaa
{
	public partial class Form1 : Form
	{
		private MySqlConnection baglanti;

		public Form1()
		{
			InitializeComponent();

			// Veritabanı bağlantısını oluştur
			VeriTabaniBaglantisi veritabaniBaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabaniBaglantisi.baglan();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			// Form yüklendiğinde yapılacak işlemler
		}

		//private void button9_Click_1(object sender, EventArgs e)
		//{
		//	string kullaniciAdi = textBox1.Text;
		//	string sifre = textBox2.Text;

		//	if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
		//	{
		//		MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		//		return;
		//	}

		//	try
		//	{
		//		if (baglanti.State != ConnectionState.Open)
		//		{
		//			baglanti.Open();
		//		}

		//		string query = "SELECT ad, yetkiler.yetki_adi FROM personeller " +
		//					   "JOIN yetkiler ON personeller.yetki_id = yetkiler.yetki_id " +
		//					   "WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

		//		using (MySqlCommand komut = new MySqlCommand(query, baglanti))
		//		{
		//			komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
		//			komut.Parameters.AddWithValue("@sifre", sifre);

		//			using (MySqlDataReader reader = komut.ExecuteReader())
		//			{
		//				if (reader.Read())
		//				{
		//					// Kullanıcı bilgilerini al
		//					string personelAd = reader["ad"].ToString();
		//					string yetki = reader["yetki_adi"].ToString();

		//					// Yeni formu aç ve bilgileri aktar
		//					anaform anaForm = new anaform(personelAd, yetki);
		//					anaForm.Show();

		//					this.Hide();
		//				}
		//				else
		//				{
		//					MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	finally
		//	{
		//		if (baglanti.State == ConnectionState.Open)
		//		{
		//			baglanti.Close();
		//		}
		//	}
		//}



		private void button9_Click_1(object sender, EventArgs e)
		{
			string kullaniciAdi = textBox1.Text;
			string sifre = textBox2.Text;

			if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
			{
				MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}

				// Giriş yapan kullanıcının ID'sini de alacak sorgu
				string query = "SELECT personeller.id, personeller.ad, yetkiler.yetki_adi FROM personeller " +
							   "JOIN yetkiler ON personeller.yetki_id = yetkiler.yetki_id " +
							   "WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

				using (MySqlCommand komut = new MySqlCommand(query, baglanti))
				{
					komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
					komut.Parameters.AddWithValue("@sifre", sifre);

					using (MySqlDataReader reader = komut.ExecuteReader())
					{
						if (reader.Read())
						{
							// Kullanıcı bilgilerini al
							int personelId = Convert.ToInt32(reader["id"]);
							string personelAd = reader["ad"].ToString();
							string yetki = reader["yetki_adi"].ToString();

							// Yeni formu aç ve bilgileri aktar
							anaform anaForm = new anaform(personelAd, yetki, personelId);
							anaForm.Show();

							this.Hide();
						}
						else
						{
							MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (baglanti.State == ConnectionState.Open)
				{
					baglanti.Close();
				}
			}
		}


		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
