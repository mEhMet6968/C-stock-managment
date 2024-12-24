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
 class yetki
	{
		public int YetkiId {  get; set; }
		public string YetkiAdi { get; set; }
		public string Aciklama { get; set; }
		VeriTabaniBaglantisi veritabanibaglantisi;
		MySqlConnection baglanti;
		MySqlCommand komut;
		public yetki()
		{
			veritabanibaglantisi = new VeriTabaniBaglantisi();
			baglanti = veritabanibaglantisi.baglan();
			komut = new MySqlCommand();
			komut.Connection = baglanti;
		}


		public DataTable yetkilerilistele()
		{
			try
			{
				komut.CommandText = "SELECT * FROM yetkiler ORDER BY yetki_adi ASC";
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
