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
	class tedarikci
	{
		public int tedarikciId {  get; set; }
		public string tedarikcifirmaadi { get; set; }
		public string tedarikciyetkiliadi { get; set; }
		public string tedarikcitel {  get; set; }
		public string tedarikcimail {  get; set; }
		public string tedarikciadres {  get; set; }


		VeriTabaniBaglantisi veritabaniBaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;
		 
		public tedarikci()
		{
			veritabaniBaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabaniBaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;


		}
		public void TedarikciEkle() 
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "INSERT INTO tedarikciler(firma_adi,yetkili_adsoyad,telefon,mail,adres) " +
					"VALUES(@firmaname,@yetkiliname,@tel,@mail,@adres)";
				komut.Parameters.AddWithValue("@firmaname",tedarikcifirmaadi);

				komut.Parameters.AddWithValue("@yetkiliname", tedarikciyetkiliadi);
				komut.Parameters.AddWithValue("@tel", tedarikcitel);
				komut.Parameters.AddWithValue("@mail", tedarikcimail);
				komut.Parameters.AddWithValue("@adres", tedarikciadres);
				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("Kayıt işlemi başarılı");

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Kayıt işlemi hatası");

			}
		}
		public void TedarikciSil()
		{
			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "DELETE FROM tedarikciler WHERE id=@tedarikciId";
				komut.Parameters.AddWithValue("tedarikciId", tedarikciId);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Sime başarılı");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "silme işlemi hatası");
			}
		}
		public void TedarikciGuncelle() 
		{

			try
			{
				if (baglanti.State != ConnectionState.Open)
				{
					baglanti.Open();
				}
				komut.CommandText = "UPDATE tedarikciler SET firma_adi=@firmaname,yetkili_adsoyad=@yetkiliname,telefon=@tel,mail=@mail,adres=@adres"+
					" where id=@tedarikciId";
				
				komut.Parameters.AddWithValue("@firmaname", tedarikcifirmaadi);
				komut.Parameters.AddWithValue("@tedarikciId", tedarikciId);

				komut.Parameters.AddWithValue("@yetkiliname", tedarikciyetkiliadi);
				komut.Parameters.AddWithValue("@tel", tedarikcitel);
				komut.Parameters.AddWithValue("@mail", tedarikcimail);
				komut.Parameters.AddWithValue("@adres", tedarikciadres);
				komut.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("güncelleme işlemi başarılı");


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Güncelleme işlemi hatası");
			}


		}

	public DataTable TedarikciListele() 
		
	{
			try
			{
				komut.CommandText = "SELECT * FROM tedarikciler ORDER BY firma_adi,yetkili_adsoyad,telefon,mail,adres ASC";
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




	}
}
