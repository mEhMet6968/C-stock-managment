using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace calismaa
{
	internal class VeriTabaniBaglantisi
	{
		string baglantiCumlesi = ConfigurationManager.ConnectionStrings["StokTakipBaglantiCumlesi"].ConnectionString;

		public MySqlConnection baglan()
		{
			MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
			MySqlConnection.ClearPool(baglanti);
			return baglanti;
		}
	}
}
