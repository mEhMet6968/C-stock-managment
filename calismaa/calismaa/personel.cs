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
	class personel
	{
		public int personelid {  get; set; }
		public string personelad { get; set; }
		public string personelsoyad { get; set; }

		public string personeltel { get; set; }
		public string personelmail { get; set; }
		public string personeladres { get; set; }

		public string personelkullaniciadi { get; set; }
		public string personelsifre { get; set; }
		public int yetkiId { get; set; }

		VeriTabaniBaglantisi veritabaniBaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;

		public personel()
		{
			veritabaniBaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabaniBaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;


		}
		public void personelekle() 
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "INSERT INTO personeller(ad,soyad,telefon,mail,adres,kullanici_adi,sifre,yetki_id) " +
					"VALUES(@personelAd,@personelSoyad,@personelTel,@PersonelMail,@PersonelAdres,@personelKullaniciadi,@personelSifre,@PersonelYetkiId)";
				komut.Parameters.AddWithValue("@personelAd", personelad);

				komut.Parameters.AddWithValue("@personelSoyad", personelsoyad);
				komut.Parameters.AddWithValue("@personelTel", personeltel);
				komut.Parameters.AddWithValue("@PersonelMail", personelmail);
				komut.Parameters.AddWithValue("@PersonelAdres", personeladres);
				komut.Parameters.AddWithValue("@personelKullaniciadi", personelkullaniciadi);
				komut.Parameters.AddWithValue("@personelSifre", personelsifre);
				komut.Parameters.AddWithValue("@PersonelYetkiId", yetkiId);
				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("Kayıt işlemi başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Kayıt işlemi hatası");

			}
		}
		public void personelsil() 
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "DELETE FROM personeller WHERE id=@tedarikciId";
				komut.Parameters.AddWithValue("tedarikciId", personelid);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Sime başarılı");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "silme işlemi hatası");
			}

		}
		public DataTable personellistele() {


			try
			{
				komut.CommandText = "SELECT personeller.id,personeller.ad, personeller.soyad, personeller.telefon, personeller.mail, personeller.adres, personeller.kullanici_adi, personeller.sifre, yetkiler.yetki_adi, yetkiler.yetki_id\r\nFROM personeller\r\nJOIN yetkiler ON personeller.yetki_id = yetkiler.yetki_id\r\nORDER BY personeller.ad ASC, personeller.soyad ASC;";
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
				DataTable kisilistesi = new DataTable();
				dataAdapter.Fill(kisilistesi);
				return kisilistesi;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Kayıt işlemi hatası");
				return null;
			}




		}
		public void personelguncelle() 
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "UPDATE personeller SET ad=@personelAd,soyad=@personelSoyad,telefon=@personelTel,mail=@PersonelMail,adres=@PersonelAdres,kullanici_adi=@personelKullaniciadi,sifre=@personelSifre " +
					",yetki_id=@PersonelYetkiId where id=@personelid";


				// ad,soyad,telefon,mail,adres,kullanici_adi,sifre
				komut.Parameters.AddWithValue("@personelid", personelid);

				komut.Parameters.AddWithValue("@personelAd", personelad);
				komut.Parameters.AddWithValue("@personelSoyad", personelsoyad);
				komut.Parameters.AddWithValue("@personelTel", personeltel);
				komut.Parameters.AddWithValue("@PersonelMail", personelmail);
				komut.Parameters.AddWithValue("@PersonelAdres", personeladres);
				komut.Parameters.AddWithValue("@personelKullaniciadi", personelkullaniciadi);
				komut.Parameters.AddWithValue("@personelSifre", personelsifre);
				komut.Parameters.AddWithValue("@PersonelYetkiId", yetkiId);
				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("güncelleme işlemi başarılı");


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Güncelleme işlemi hatası");
			}



		}


	}
}
