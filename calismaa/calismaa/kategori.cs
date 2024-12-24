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
	 class kategori
	{
			public int kategoriId {  get; set; }
		public string kategoriAdi { get; set; }
		VeriTabaniBaglantisi veritabanibaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;
		public kategori()
		{
			veritabanibaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabanibaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;
		}
		public void kategoriekle() {
			try
			{
				if(baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "INSERT INTO kategoriler(kategori_adi) " + "VALUES(@kategoriadi)";
				komut.Parameters.AddWithValue("@kategoriadi", kategoriAdi);
				komut.ExecuteNonQuery();
				MessageBox.Show("Kayıt başarılı");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Kayıt işlemi hatası");
			}
			baglanti.Close();


		}
		public void kategorisil() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "DELETE FROM kategoriler WHERE kategori_id=@kategoriId";
				komut.Parameters.AddWithValue("@kategoriId", kategoriId);
				komut.ExecuteNonQuery();
				MessageBox.Show("Silme başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "silme işlemi hatası");

			}
			baglanti.Close();



		}
		public void kategoriguncelle() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "UPDATE kategoriler SET kategori_adi=@kategoriadi "+
					"where kategori_id=@kategoriId";
				komut.Parameters.AddWithValue("@kategoriId", kategoriId);
				komut.Parameters.AddWithValue("@kategoriadi", kategoriAdi);
				komut.ExecuteNonQuery();
				MessageBox.Show("güncelleme başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "guncelleme işlemi hatası");

			}
			baglanti.Close();

		}
		public DataTable kategorilistele()
		{
			try
			{
				komut.CommandText = "SELECT * FROM kategoriler ORDER BY kategori_adi ASC";
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



	}
}
