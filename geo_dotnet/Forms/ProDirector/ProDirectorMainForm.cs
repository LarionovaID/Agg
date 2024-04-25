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
	public partial class ProDirectorMainForm : Form
	{
		Database db = new Database();

		int projectsSelectedRow;
		int areasSelectedRow;
		int profilesSelectedRow;
		int picketsSelectedRow;

		public ProDirectorMainForm()
		{
			InitializeComponent();
		}

		private void ProDirectorMainForm_Load(object sender, EventArgs e)
		{
			CreateColomns();
		}

		// Создание полей таблиц
		private void CreateColomns()
		{
			dgv_Projects.Columns.Add("Id", "Id");
			dgv_Projects.Columns.Add("DateStart", "Начало");
			dgv_Projects.Columns.Add("DateEnd", "Конец");
			dgv_Projects.Columns.Add("Descriptoin", "Описание");
			dgv_Projects.Columns.Add("CustomerId", "Заказчик");
			dgv_Projects.Columns.Add("UserId_Worker", "Работник");

			dgv_Areas.Columns.Add("Id", "Id");
			dgv_Areas.Columns.Add("AreaSize", "Размер площади");
			dgv_Areas.Columns.Add("Coordinates", "Координаты");
			dgv_Areas.Columns.Add("Adress", "Адрес");

			dgv_Profiles.Columns.Add("Id", "Id");
			dgv_Profiles.Columns.Add("AreaId", "Площадь");
			dgv_Profiles.Columns.Add("Coordinates", "Координаты");
			dgv_Profiles.Columns.Add("Distance", "Дистанция");

			dgv_Pickets.Columns.Add("Id", "Id");
			dgv_Pickets.Columns.Add("Coordinates", "Координаты");
			dgv_Pickets.Columns.Add("ProfileId", "Профиль");

			dgv_Measurements.Columns.Add("Id", "Id");
			dgv_Measurements.Columns.Add("DataMeas", "Данные");
			dgv_Measurements.Columns.Add("Date", "Дата");
			dgv_Measurements.Columns.Add("PicketId", "Пикет");
			dgv_Measurements.Columns.Add("UserId_Worker", "Работник");
		}


		private void Projects_ReadRow(DataGridView dgv, IDataRecord record)
		{

			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string dateStart = record.IsDBNull(1) ? string.Empty : record.GetDateTime(1).ToString();
			string dateEnd = record.IsDBNull(2) ? string.Empty : record.GetDateTime(2).ToString();
			string descriptoin = record.IsDBNull(3) ? string.Empty : record.GetString(3);
			string customerId = record.IsDBNull(4) ? string.Empty : record.GetString(4);
			string userId_Worker = record.IsDBNull(5) ? string.Empty : record.GetString(5);


			dgv.Rows.Add(id, dateStart, dateEnd, descriptoin, customerId, userId_Worker);

			/*dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);*/
		}

		private void btn_Projects_Click(object sender, EventArgs e)
		{
			dgv_Projects.Rows.Clear();
			dgv_Areas.Rows.Clear();
			dgv_Profiles.Rows.Clear();
			dgv_Pickets.Rows.Clear();
			dgv_Measurements.Rows.Clear();

			string queryString = $"select P.Id, P.DateStart, P.DateEnd, P.Descriptoin, C.[Name], U.Fio from Projects as P LEFT JOIN CustomerCompanies AS C ON P.CustomerId = C.Id LEFT JOIN Users AS U ON P.UserId_Worker = U.Id;";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				/*int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
				string dateStart = record.IsDBNull(1) ? string.Empty : record.IsDBNull(1) ? string.Empty : record.GetString(1);
				string dateEnd = record.IsDBNull(2) ? string.Empty : record.GetString(2);
				string descriptoin = record.IsDBNull(3) ? string.Empty : record.GetString(3);
				int customerId = record.IsDBNull(4) ? 0 : record.GetInt32(4);
				int userId_Worker = record.IsDBNull(4) ? 0 : record.GetInt32(4);
				*/


				Projects_ReadRow(dgv_Projects, sqlDataReader);

				//dgv_Projects.Rows.Add(id, login, password, fio, roleId, RowState.ModifiedNew);
			}
			sqlDataReader.Close();
		}


		private void Areas_ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string areaSize = record.IsDBNull(1) ? string.Empty : record.GetString(1);
			string coordinates = record.IsDBNull(2) ? string.Empty : record.GetString(2);
			string adress = record.IsDBNull(3) ? string.Empty : record.GetString(3);

			dgv.Rows.Add(id, areaSize, coordinates, adress);
		}
		private void btn_Areas_Click(object sender, EventArgs e)
		{

		}



		private void dgv_Projects_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}


		private void Profiles_ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			int areaId = record.IsDBNull(1) ? 0 : record.GetInt32(1);

			string coordinates = record.IsDBNull(2) ? string.Empty : record.GetString(2);
			string distance = record.IsDBNull(3) ? string.Empty : record.GetString(3);

			dgv.Rows.Add(id, areaId, coordinates, distance);
		}
		private void dgv_Areas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void Pickets_ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string coordinates = record.IsDBNull(1) ? string.Empty : record.GetString(1);
			int profileId = record.IsDBNull(2) ? 0 : record.GetInt32(2);

			dgv.Rows.Add(id, coordinates, profileId);
		}
		private void dgv_Profiles_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Meas_ReadRow(DataGridView dgv, IDataRecord record)
		{
			int id = record.IsDBNull(0) ? 0 : record.GetInt32(0);
			string dataMeas = record.IsDBNull(1) ? string.Empty : record.GetString(1);
			string date = record.IsDBNull(2) ? string.Empty : record.GetDateTime(2).ToString();
			int picketId = record.IsDBNull(3) ? 0 : record.GetInt32(3);
			int userId_Worker = record.IsDBNull(4) ? 0 : record.GetInt32(4);

			dgv.Rows.Add(id, dataMeas, date, picketId, userId_Worker);
		}
		private void dgv_Pickets_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dgv_Projects_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv_Areas.Rows.Clear();
			dgv_Profiles.Rows.Clear();
			dgv_Pickets.Rows.Clear();
			dgv_Measurements .Rows.Clear();

			projectsSelectedRow = e.RowIndex;
			DataGridViewRow row0 = dgv_Projects.Rows[projectsSelectedRow];

			/*var selectedRowId = 20;*/

			int selectedRowId0 = Convert.ToInt32(row0.Cells[0].Value); // Предполагается, что id находится в первом столбце

			string queryString = $"select A.Id, A.AreaSize, A.Coordinates, A.Adress from ProjectsAreas as PA LEFT JOIN Areas AS A ON PA.AreaId = A.Id where PA.ProjectId = {selectedRowId0}";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			//selectedRow = d.RowIndex;

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				Areas_ReadRow(dgv_Areas, sqlDataReader);
			}

			sqlDataReader.Close();
		}

		private void dgv_Areas_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv_Profiles.Rows.Clear();
			dgv_Pickets.Rows.Clear();
			dgv_Measurements.Rows.Clear();

			areasSelectedRow = e.RowIndex;
			DataGridViewRow row1 = dgv_Areas.Rows[areasSelectedRow];

			/*var selectedRowId = 20;*/

			int selectedRowId1 = Convert.ToInt32(row1.Cells[0].Value); // Предполагается, что id находится в первом столбце

			string queryString = $"select Id, AreaId, Coordinates, Distance from Profiles where AreaId = {selectedRowId1}";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			//selectedRow = d.RowIndex;

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				Profiles_ReadRow(dgv_Profiles, sqlDataReader);
			}

			sqlDataReader.Close();
		}

		private void dgv_Profiles_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv_Pickets.Rows.Clear();
			dgv_Measurements.Rows.Clear();

			profilesSelectedRow = e.RowIndex;
			DataGridViewRow row = dgv_Profiles.Rows[profilesSelectedRow];

			/*var selectedRowId = 20;*/

			int selectedRowId2 = Convert.ToInt32(row.Cells[0].Value); // Предполагается, что id находится в первом столбце

			string queryString = $"select * from Pickets where ProfileId = {selectedRowId2}";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			//selectedRow = d.RowIndex;

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				Pickets_ReadRow(dgv_Pickets, sqlDataReader);
			}

			sqlDataReader.Close();
		}

		private void dgv_Pickets_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv_Measurements.Rows.Clear();

			picketsSelectedRow = e.RowIndex;
			DataGridViewRow row = dgv_Pickets.Rows[picketsSelectedRow];

			/*var selectedRowId = 20;*/

			int selectedRowId3 = Convert.ToInt32(row.Cells[0].Value); // Предполагается, что id находится в первом столбце

			string queryString = $"select * from Measurements where PicketId = {selectedRowId3}";

			SqlCommand sqlCommand = new SqlCommand(queryString, db.GetConnection());


			db.OpenConnection();

			//selectedRow = d.RowIndex;

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				Meas_ReadRow(dgv_Measurements, sqlDataReader);
			}

			sqlDataReader.Close();
		}
	}
}

