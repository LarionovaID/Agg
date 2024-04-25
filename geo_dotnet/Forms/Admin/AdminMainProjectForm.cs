using geo_dotnet.Controls;
using geo_dotnet.Controls.Admin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geo_dotnet.Forms.Admin
{
	/*enum RowState
	{
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted
	}*/

	public partial class AdminMainProjectForm : Form
	{
		Database db = new Database();

		int selectedRow;

		public AdminMainProjectForm()
		{
			InitializeComponent();

			//AdminPanel adminPanel = new AdminPanel(this); // Передача ссылки на родительскую форму
		}

		private void AdminMainProjectForm_Load(object sender, EventArgs e)
		{
			CreateColomns();
			RefreshDataGrid(dgv_Projects);

			Fill_cb_Workers();
			Fill_cb_Customers();
		}

		private void CreateColomns()
		{
			dgv_Projects.Columns.Add("Id", "Id");
			dgv_Projects.Columns.Add("DateStart", "Начало");
			dgv_Projects.Columns.Add("DateEnd", "Конец");
			dgv_Projects.Columns.Add("Descriptoin", "Описание");
			dgv_Projects.Columns.Add("CustomerId", "Заказчик");
			dgv_Projects.Columns.Add("UserId_Worker", "Работник");

			dgv_Projects.Columns.Add("Status", "Статус");
		}
		private void ClearFields()
		{
			tb_Id.Text = "";
			tb_DateStart.Text = "";
			tb_DateEnd.Text = "";
			cb_Worker.Text = "";
			cb_Customer.Text = "";
			tb_Description.Text = "";
		}

		private void ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string dateStart = record.IsDBNull(1) ? string.Empty : record.GetDateTime(1).ToString();
			string dateEnd = record.IsDBNull(2) ? string.Empty : record.GetDateTime(2).ToString();
			string descriptoin = record.IsDBNull(3) ? string.Empty : record.GetString(3);
			string customerId = record.IsDBNull(4) ? string.Empty : record.GetString(4);
			string userId_Worker = record.IsDBNull(5) ? string.Empty : record.GetString(5);


			dgv.Rows.Add(id, dateStart, dateEnd, descriptoin, customerId, userId_Worker, RowState.ModifiedNew);

			/*dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);*/
		}


		// Вывод таблиы
		private void RefreshDataGrid(DataGridView dgv)
		{
			dgv.Rows.Clear();

			string queryString = $"select P.Id, P.DateStart, P.DateEnd, P.Descriptoin, C.[Name], U.Fio from Projects as P LEFT JOIN CustomerCompanies AS C ON P.CustomerId = C.Id LEFT JOIN Users AS U ON P.UserId_Worker = U.Id;";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());

			db.OpenConnection();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				ReadRow(dgv, sqlDataReader);
			}
			sqlDataReader.Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void dgv_Projects_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgv_Projects.Rows[selectedRow];

				tb_Id.Text = row.Cells[0].Value.ToString();
				tb_DateStart.Text = row.Cells[1].Value.ToString();
				tb_DateEnd.Text = row.Cells[2].Value.ToString();
				tb_Description.Text = row.Cells[3].Value.ToString();
				cb_Customer.Text = row.Cells[4].Value.ToString();

				cb_Worker.Text = row.Cells[5].Value.ToString();

			}
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dgv_Projects);
			ClearFields();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			AddProjectDialogForm addProjectDialogForm = new AddProjectDialogForm();
			addProjectDialogForm.ShowDialog();
		}

		private void Search(DataGridView dgv)
		{
			dgv.Rows.Clear();

			string searchString = $"select * from Projects where concat (Id, DateStart, DateEnd, Descriptoin, CustomerId, UserId_Worker) like '%" + tb_Search.Text + "%' ";

			SqlCommand command = new SqlCommand(searchString, db.GetConnection());

			db.OpenConnection();

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				ReadRow(dgv, reader);
			}

			reader.Close();

		}
		private void tb_Search_TextChanged(object sender, EventArgs e)
		{
			Search(dgv_Projects);

		}


		private void DeleteRow()
		{
			int index = dgv_Projects.CurrentCell.RowIndex;

			dgv_Projects.Rows[index].Visible = false;

			/*if (dgv_Users.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				return;
			}*/

			dgv_Projects.Rows[index].Cells[6].Value = RowState.Deleted;

		}
		private void btn_Delete_Click(object sender, EventArgs e)
		{
			DeleteRow();
			ClearFields();
		}

		private void Update1()
		{
			db.OpenConnection();

			for (int index = 0; index < dgv_Projects.Rows.Count; index++)
			{
				var rowState = (RowState)dgv_Projects.Rows[index].Cells[6].Value;

				if (rowState == RowState.Existed) continue;

				if (rowState == RowState.Deleted)
				{
					var id = Convert.ToInt32(dgv_Projects.Rows[index].Cells[0].Value);

					var deleteQuery = $"delete from Projects where id = {id}";

					var command = new SqlCommand(deleteQuery, db.GetConnection());
					command.ExecuteNonQuery();
				}

				if (rowState == RowState.Modified)
				{
					var id = dgv_Projects.Rows[index].Cells[0].Value.ToString();
					var dateStart = dgv_Projects.Rows[index].Cells[1].Value.ToString();
					var dateEnd = dgv_Projects.Rows[index].Cells[2].Value.ToString();
					var descriptoin = dgv_Projects.Rows[index].Cells[3].Value.ToString();
					var customerId = dgv_Projects.Rows[index].Cells[4].Value.ToString();
					var userId_Worker = dgv_Projects.Rows[index].Cells[5].Value.ToString();

					var editQuery = $"update Projects set DateStart = '{dateStart}', DateEnd = '{dateEnd}', Descriptoin = '{descriptoin}', CustomerId = '{customerId}', UserId_Worker = '{userId_Worker}' where Id = {id}";

					var command = new SqlCommand(editQuery, db.GetConnection());
					command.ExecuteNonQuery();
				}

			}

			db.CloseConnection();
		}
		private void btn_Save_Click(object sender, EventArgs e)
		{
			Update1();
		}


		private void Edit()
		{
			var selectedRowIndex = dgv_Projects.CurrentCell.RowIndex;

			var id = tb_Id.Text;
			var dateStart = tb_DateStart.Text;
			var dateEnd = tb_DateEnd.Text;
			var descriptoin = tb_Description.Text;
			var customerId = cb_Worker.Text;
			var userId_Worker = cb_Customer.Text;



			if (dgv_Projects.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
			{
				dgv_Projects.Rows[selectedRowIndex].SetValues(id, dateStart, dateEnd, descriptoin, customerId, userId_Worker);
				dgv_Projects.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
			}
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			Edit();
			ClearFields();
		}

		private void dgv_Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tb_Worker_TextChanged(object sender, EventArgs e)
		{

		}



		private void Fill_cb_Workers()
		{
			db.OpenConnection();

			string query = "select * from Users where RoleId=2;";

			SqlCommand command = new SqlCommand(query, db.GetConnection());
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				cb_Worker.Items.Add(reader["Fio"].ToString());
			}

			db.CloseConnection();
		}
		private void Fill_cb_Customers()
		{
			db.OpenConnection();

			string query = "select * from Users where RoleId=3;";

			SqlCommand command = new SqlCommand(query, db.GetConnection());
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				cb_Customer.Items.Add(reader["Fio"].ToString());
			}

			db.CloseConnection();
		}
		private void cb_Worker_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void cb_Customer_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			int projId = int.Parse(tb_Id.Text);

			AllAdminform allAdminform = new AllAdminform();
			allAdminform.projId = projId;
			allAdminform.ShowDialog();
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void tb_DateEnd_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void tb_DateStart_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tb_Description_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tb_Id_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
