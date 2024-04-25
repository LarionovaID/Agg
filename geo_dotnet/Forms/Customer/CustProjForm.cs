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

namespace geo_dotnet.Forms.Customer
{
	public partial class CustProjForm : Form
	{
		public int userId {  get; set; }

		Database db = new Database();

		int selectedRow;


		public CustProjForm()
		{
			InitializeComponent();
		}


		private void CustProjForm_Load(object sender, EventArgs e)
		{
			CreateColomns();


			dgv_Projects.Rows.Clear();

			int uId = this.userId;


			string queryString = $"select P.Id, P.DateStart, P.DateEnd, P.Descriptoin, P.CustomerId, P.UserId_Worker from Projects as P LEFT JOIN CustomerCompanies AS CC ON P.CustomerId = CC.Id LEFT JOIN Users AS U ON CC.UserId = U.Id where U.Id = {uId};";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());

			db.OpenConnection();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				ReadRow(dgv_Projects, sqlDataReader);
			}
			sqlDataReader.Close();
		}


		private void button4_Click(object sender, EventArgs e)
		{
			int projId = int.Parse(tb_Id.Text);

			CustomerProjDForm proj = new CustomerProjDForm();
			proj.projId = projId;
			proj.ShowDialog();
		}

		private void CreateColomns()
		{
			dgv_Projects.Columns.Add("Id", "Id");
			dgv_Projects.Columns.Add("DateStart", "Начало");
			dgv_Projects.Columns.Add("DateEnd", "Конец");
			dgv_Projects.Columns.Add("Descriptoin", "Описание");
			dgv_Projects.Columns.Add("CustomerId", "Заказчик");
			dgv_Projects.Columns.Add("UserId_Worker", "Работник");

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

		private void ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string dateStart = record.IsDBNull(1) ? string.Empty : record.GetDateTime(1).ToString();
			string dateEnd = record.IsDBNull(2) ? string.Empty : record.GetDateTime(2).ToString();
			string descriptoin = record.IsDBNull(3) ? string.Empty : record.GetString(3);
			int customerId = record.IsDBNull(4) ? 0 : record.GetInt32(4);
			int userId_Worker = record.IsDBNull(5) ? 0 : record.GetInt32(5);


			dgv.Rows.Add(id, dateStart, dateEnd, descriptoin, customerId, userId_Worker, RowState.ModifiedNew);

			/*dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);*/
		}
	

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void dgv_Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
