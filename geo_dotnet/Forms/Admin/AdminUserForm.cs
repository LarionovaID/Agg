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

using geo_dotnet;
using geo_dotnet.Controls;

namespace geo_dotnet.Forms.Admin
{
	enum RowState 
	{ 
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted
	}

	public partial class AdminUserForm : Form
	{
		Database db = new Database();

		int selectedRow;

		public AdminUserForm()
		{
			InitializeComponent();

			//AdminPanel adminPanel = new AdminPanel(this); // Передача ссылки на родительскую форму
		}

		// Создание полей таблицы
		private void CreateColomns()
		{
			dgv_Users.Columns.Add("Id", "id");
			dgv_Users.Columns.Add("Login", "Логин");
			dgv_Users.Columns.Add("Password", "Пароль");
			dgv_Users.Columns.Add("Fio", "ФИО");
			dgv_Users.Columns.Add("RoleId", "Роль");
			dgv_Users.Columns.Add("Status", "");
		}

		private void ClearFields()
		{
			tb_Id.Text = "";
			tb_Login.Text = "";
			tb_Password.Text = "";
			tb_Fio.Text = "";
			cb_Role.Text = "";
		}

			// Чтение строк таблицы
		private void ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string login = record.IsDBNull(1) ? string.Empty : record.GetString(1);
			string password = record.IsDBNull(2) ? string.Empty : record.GetString(2);
			string fio = record.IsDBNull(3) ? string.Empty : record.GetString(3);
			int roleId = record.IsDBNull(4) ? 0 : record.GetInt32(4);

			dgv.Rows.Add(id, login, password, fio, roleId, RowState.ModifiedNew);

			/*dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);*/
		}

		// Вывод таблиы
		private void RefreshDataGrid(DataGridView dgv)
		{
			dgv.Rows.Clear();

			string queryString = $"select * from Users";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				ReadRow(dgv, sqlDataReader);
			}
			sqlDataReader.Close();
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

		private void AdminUserForm_Load(object sender, EventArgs e)
		{
			CreateColomns();
			RefreshDataGrid(dgv_Users);

			Fill_cb_Role();
		}


		private void btn_Add_Click(object sender, EventArgs e)
		{
			EditUserDialogForm editUserDialogForm = new EditUserDialogForm();
			editUserDialogForm.ShowDialog();
		}


		private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgv_Users.Rows[selectedRow];

				tb_Id.Text = row.Cells[0].Value.ToString();
				tb_Login.Text = row.Cells[1].Value.ToString();
				tb_Password.Text = row.Cells[2].Value.ToString();
				tb_Fio.Text = row.Cells[3].Value.ToString();
				cb_Role.Text = row.Cells[4].Value.ToString();

			}
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dgv_Users);
			ClearFields();
		}



		private void Search(DataGridView dgv)
		{
			dgv.Rows.Clear();

			string searchString = $"select * from Users where concat (Id, Login, Password, Fio, RoleId) like '%" + tb_Search.Text + "%' ";
		
			SqlCommand command = new SqlCommand(searchString, db.GetConnection());


			db.OpenConnection();

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				ReadRow(dgv, reader);
			}

			reader.Close();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Search(dgv_Users);
		}


		private void DeleteRow()
		{
			int index = dgv_Users.CurrentCell.RowIndex;

			dgv_Users.Rows[index].Visible = false;

			/*if (dgv_Users.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				return;
			}*/

			dgv_Users.Rows[index].Cells[5].Value = RowState.Deleted;

		}

		private void Update1()
		{
			db.OpenConnection();

			for(int index = 0; index < dgv_Users.Rows.Count; index++)
			{
				var rowState = (RowState)dgv_Users.Rows[index].Cells[5].Value;

				if (rowState == RowState.Existed) continue;

				if (rowState == RowState.Deleted)
				{
					var id = Convert.ToInt32(dgv_Users.Rows[index].Cells[0].Value);

					var deleteQuery = $"delete from Users where id = {id}";

					var command = new SqlCommand(deleteQuery, db.GetConnection());
					command.ExecuteNonQuery();
				}

				if (rowState == RowState.Modified)
				{
					var id = dgv_Users.Rows[index].Cells[0].Value.ToString();
					var login = dgv_Users.Rows[index].Cells[1].Value.ToString();
					var password = dgv_Users.Rows[index].Cells[2].Value.ToString();
					var fio = dgv_Users.Rows[index].Cells[3].Value.ToString();
					var roleId = dgv_Users.Rows[index].Cells[4].Value.ToString();

					var editQuery = $"update Users set Login = '{login}', Password = '{password}', Fio = '{fio}', RoleId = '{roleId}' where Id = {id}";

					var command = new SqlCommand(editQuery, db.GetConnection());
					command.ExecuteNonQuery();
				}

			}

			db.CloseConnection();
		}
		private void btn_Delete_Click(object sender, EventArgs e)
		{
			DeleteRow();
			ClearFields();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			Update1();
		}


		private void Edit()
		{
			var selectedRowIndex = dgv_Users.CurrentCell.RowIndex;

			var id = tb_Id.Text;
			var login = tb_Login.Text;
			var password = tb_Password.Text;
			var fio = tb_Fio.Text;
			var roleId = cb_Role.Text;

			if(dgv_Users.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
			{
				dgv_Users.Rows[selectedRowIndex].SetValues(id, login, password, fio, roleId);
				dgv_Users.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
			}
		}
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			Edit();
			ClearFields();
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
