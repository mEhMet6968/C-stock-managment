using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaa
{
	public partial class listele : Form
	{
		public listele()
		{
			InitializeComponent();
		}

		private void listele_Load(object sender, EventArgs e)
		{
			ListeleSatislar();
		}
		private void ListeleSatislar()
		{
			try
			{
				// Veritabanı bağlantısı
				string connectionString = "server=localhost;database=db;uid=root;pwd=1234";
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					// SQL sorgusu
					string query = "SELECT * FROM satislar";

					using (MySqlCommand command = new MySqlCommand(query, connection))
					{
						using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
						{
							// Verileri doldur
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							// DataGridView'e bağla
							dataGridView1.DataSource = dt;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
