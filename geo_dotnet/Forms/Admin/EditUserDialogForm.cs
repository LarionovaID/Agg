using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace geo_dotnet.Forms.Admin
{
	public partial class EditUserDialogForm : Form
	{
		Database db = new Database();
		
		public EditUserDialogForm()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			db.OpenConnection();

			var login = tb_Login.Text;
			var pswd = tb_Password.Text;
			var fio = tb_Fio.Text;
			var role = cb_Role.Text;
			/*var phone = tb_Phone.Text;*/


			var addQuery = $"insert into Users (Login, Password, Fio, RoleId) values ('{login}', '{pswd}', '{fio}', '{role}')";

			var command = new SqlCommand(addQuery, db.GetConnection());
			command.ExecuteNonQuery();

			MessageBox.Show("Пользователь создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

			db.CloseConnection();

			this.Close();
		}

		private void EditUserDialogForm_Load(object sender, EventArgs e)
		{
			Fill_cb_Role();
		}

		private void Fill_cb_Role()
		{
			db.OpenConnection();

			string query = "select * from Roles";

			SqlCommand command = new SqlCommand(query, db.GetConnection());
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				cb_Role.Items.Add(reader["Id"].ToString());
			}

			db.CloseConnection();
		}
	}
}
