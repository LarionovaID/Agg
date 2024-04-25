using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geo_dotnet.Forms.Admin
{
	public partial class AddProjectDialogForm : Form
	{
		Database db = new Database();

		public AddProjectDialogForm()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
		}

		private void AddProjectDialogForm_Load(object sender, EventArgs e)
		{
			Fill_cb_Workers();
			Fill_cb_Customers();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			db.OpenConnection();

			var dateStart = DateTime.Parse(dateTimePicker1.Text);
			var dateEnd = DateTime.Parse(dateTimePicker2.Text);
			var descriptoin = tb_Description.Text;
			var customerId = cb_Customer.Text;
			var userId_Worker = cb_Worker.Text;

			var addQuery = $"insert into Projects (DateStart, DateEnd, Descriptoin, CustomerId, UserId_Worker) values ('{dateStart}', '{dateEnd}', '{descriptoin}', '{customerId}', '{userId_Worker}')";

			var command = new SqlCommand(addQuery, db.GetConnection());
			command.ExecuteNonQuery();

			MessageBox.Show("Проект создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

			db.CloseConnection();

			this.Close();
		}

		private void Fill_cb_Workers()
		{
			db.OpenConnection();

			string query = "select * from Users where RoleId=2;";

			SqlCommand command = new SqlCommand(query, db.GetConnection());
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				cb_Worker.Items.Add(reader["Id"].ToString());
			}

			db.CloseConnection();
		}
		private void Fill_cb_Customers()
		{
			db.OpenConnection();

			string query = "select * from CustomerCompanies";

			SqlCommand command = new SqlCommand(query, db.GetConnection());
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				cb_Customer.Items.Add(reader["Id"].ToString());
			}

			db.CloseConnection();
		}

	}
}
