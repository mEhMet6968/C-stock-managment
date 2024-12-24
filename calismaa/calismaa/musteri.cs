using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
	class musteri
	{
		public int musteriId { get; set; }
		public string musterifirmaadi { get; set; }
		public string musteriyetkiliad { get; set; }
		public string musteritel { get; set; }
		public string musterimail { get; set; }
		public string musteriadres { get; set; }

		VeriTabaniBaglantisi veritabanibaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;
		public musteri()
		{
			veritabanibaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabanibaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;
		}
		public void musteriekle() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "INSERT INTO musteriler(firma_adi,ad_soyad,telefon,mail,adres) " + "VALUES(@firmaAdi,@yetkiliname,@tel,@mAil,@adres)";
				komut.Parameters.AddWithValue("@firmaAdi", musterifirmaadi);
				komut.Parameters.AddWithValue("@yetkiliname", musteriyetkiliad);
				komut.Parameters.AddWithValue("@tel", musteritel);
				komut.Parameters.AddWithValue("@mAil", musterimail);
				komut.Parameters.AddWithValue("@adres", musteriadres);
				komut.ExecuteNonQuery();
				MessageBox.Show("Kayıt başarılı");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Kayıt işlemi hatası");
			}
			baglanti.Close();


		}
		public void musterisil() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "DELETE FROM musteriler WHERE id=@kategoriId";
				komut.Parameters.AddWithValue("@kategoriId", musteriId);
				komut.ExecuteNonQuery();
				MessageBox.Show("Silme başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "silme işlemi hatası");

			}
			baglanti.Close();





		}
		public void musteriguncelle() {

			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "UPDATE musteriler SET firma_adi=@firmaAdi, ad_soyad=@yetkiliname, " +
								"telefon=@tel, mail=@mAil, adres=@adres " +
								"WHERE id=@musterid";
				komut.Parameters.AddWithValue("@firmaAdi", musterifirmaadi);
				komut.Parameters.AddWithValue("@yetkiliname", musteriyetkiliad);
				komut.Parameters.AddWithValue("@tel", musteritel);
				komut.Parameters.AddWithValue("@mAil", musterimail);
				komut.Parameters.AddWithValue("@adres", musteriadres);
				komut.Parameters.AddWithValue("@musterid", musteriId);

				komut.ExecuteNonQuery();
				MessageBox.Show("güncelleme başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			baglanti.Close();




		}

		public DataTable musterilistele() {



			try
			{
				komut.CommandText = "SELECT * FROM musteriler ORDER BY firma_adi ASC";
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
				DataTable grupListesi = new DataTable();
				dataAdapter.Fill(grupListesi);
				return grupListesi;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "listeleme işlemi hatası");
				return null;
			}





		}


		public (string MusteriAdi, int MusteriId) MusteriBilgileriGetir(string musteriNumara)
		{
			string musteriAdi = null;
			int musteriId = 0;

			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}

				komut.CommandText = "SELECT id, ad_soyad FROM musteriler WHERE telefon = @musteriNumara";
				komut.Parameters.Clear();
				komut.Parameters.AddWithValue("@musteriNumara", musteriNumara);

				using (MySqlDataReader reader = komut.ExecuteReader())
				{
					if (reader.Read())
					{
						musteriId = Convert.ToInt32(reader["id"]);
						musteriAdi = reader["ad_soyad"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (baglanti.State == ConnectionState.Open)
				{
					baglanti.Close();
				}
			}

			return (musteriAdi, musteriId);
		}



	}
}
