using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
	 class urun
	{
		public int urun_kodu {  get; set; }	
		public string urun_adi { get; set; }
		public int stok_adedi { get; set; }
		public decimal fiyat {  get; set; }
		public string aciklama { get; set; }
		public int tedarikci_id { get; set; }
		public int kategori_id {  get; set; }
		VeriTabaniBaglantisi veritabaniBaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;
		public urun()
		{
			veritabaniBaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabaniBaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;

		}
		public void UrunEkle() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}

				komut.CommandText = "INSERT INTO urunler(urun_adi,stok_adedi,fiyat,aciklama,tedarikci_id,kategori_id) " +
					"VALUES(@urunname,@stokadet,@fiyat,@aciklama,@tedarikciid,@kategoriid)";
				komut.Parameters.AddWithValue("@urunname", urun_adi);
				komut.Parameters.AddWithValue("@stokadet", stok_adedi);
				komut.Parameters.AddWithValue("@fiyat", fiyat);
				komut.Parameters.AddWithValue("@aciklama", aciklama);
				komut.Parameters.AddWithValue("@tedarikciid", tedarikci_id);
				komut.Parameters.AddWithValue("@kategoriid", kategori_id);
				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("Kayıt işlemi başarılı");




			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "ekleme işlemi hatası");
			}
		
		
		
		
		
		}
		//public void UrunGuncelle() {


		//	try
		//	{
		//		if (baglanti.State != ConnectionState.Open)
		//		{
		//			baglanti.Open();
		//		}

		//		komut.CommandText = "UPDATE urunler SET urun_adi=@urunname,stok_adedi=@stokadet,fiyat=@fiyat,aciklama=@aciklama,tedarikci_id=@tedarikciid,kategori_id=@kategoriid" +
		//			" where urun_kodu=@urunkoduuu";

		//		komut.Parameters.AddWithValue("@urunname", urun_adi);
		//		komut.Parameters.AddWithValue("@stokadet", stok_adedi);
		//		komut.Parameters.AddWithValue("@fiyat", fiyat);
		//		komut.Parameters.AddWithValue("@aciklama", aciklama);
		//		komut.Parameters.AddWithValue("@tedarikciid", tedarikci_id);
		//		komut.Parameters.AddWithValue("@kategoriid", kategori_id);
		//		komut.Parameters.AddWithValue("@urunkoduuu", urun_kodu);

		//		komut.ExecuteNonQuery();
		//		baglanti.Close();

		//		MessageBox.Show("güncelleme işlemi başarılı");


		//	}
		//	catch (Exception ex)
		//	{

		//		MessageBox.Show(ex.Message, "Güncelleme işlemi hatası");
		//	}


		//}
		public void UrunGuncelle()
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}

				komut.CommandText = "UPDATE urunler SET urun_adi=@urunname, stok_adedi=@stokadet, fiyat=@fiyat, " +
									"aciklama=@aciklama, tedarikci_id=@tedarikciid, kategori_id=@kategoriid " +
									"WHERE urun_kodu=@urunkoduuu";

				komut.Parameters.Clear(); // Parametreleri temizle
				komut.Parameters.AddWithValue("@urunname", urun_adi);
				komut.Parameters.AddWithValue("@stokadet", stok_adedi);
				komut.Parameters.AddWithValue("@fiyat", fiyat);
				komut.Parameters.AddWithValue("@aciklama", aciklama);
				komut.Parameters.AddWithValue("@tedarikciid", tedarikci_id);
				komut.Parameters.AddWithValue("@kategoriid", kategori_id);
				komut.Parameters.AddWithValue("@urunkoduuu", urun_kodu);

				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("Güncelleme işlemi başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Güncelleme işlemi hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void UrunSil() {
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "DELETE FROM urunler WHERE urun_kodu=@tedarikciId";
				komut.Parameters.AddWithValue("tedarikciId", urun_kodu);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Sime başarılı");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "silme işlemi hatası");
			}





		}

		public DataTable UrunleriListele() {
			try
			{
				komut.CommandText = @"
        SELECT 
            urunler.urun_kodu, 
            urunler.urun_adi, 
            urunler.stok_adedi, 
            urunler.fiyat, 
            urunler.aciklama, 
            tedarikciler.id, 
            kategoriler.kategori_id
        FROM 
            urunler
        INNER JOIN 
            tedarikciler ON urunler.tedarikci_id = tedarikciler.id
        INNER JOIN 
            kategoriler ON urunler.kategori_id = kategoriler.kategori_id";

				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
				DataTable kisilistesi = new DataTable();
				dataAdapter.Fill(kisilistesi);
				return kisilistesi;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Listeleme işlemi hatası");
				return null;
			}








		}
	




	}
}
