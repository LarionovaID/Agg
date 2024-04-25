using geo_dotnet.Forms.Admin;
using geo_dotnet.Forms.Customer;
using geo_dotnet.Forms.Employee;
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
using static System.Net.Mime.MediaTypeNames;

namespace geo_dotnet
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		Database db = new Database();

		private string text = string.Empty;

		private void Form1_Load(object sender, EventArgs e)
		{
			tb_Server.Text = "IRYSIK\\SQLEXPRESS";
			tb_dbName.Text = "GeoDb";
			tb_Login.Text = "admin";
			tb_Password.Text = "admin";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			var email = tb_Login.Text;
			var password = tb_Password.Text;

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable table = new DataTable();

			string queryString = $"select id, Login, Password, RoleId from Users where Login = '{email}' and Password = '{password}'";
			SqlCommand command = new SqlCommand(queryString, db.GetConnection(/*tb_Server.Text, tb_dbName.Text*/));

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count == 1)
			{
				MessageBox.Show("done!", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);

				string role = table.Rows[0]["RoleId"].ToString();
				int id = int.Parse(table.Rows[0]["id"].ToString());


				if (role == "1")
				{
					AdminMainProjectForm adminMainProjectForm = new AdminMainProjectForm();
					this.Hide();
					adminMainProjectForm.ShowDialog();
					this.Show();
				}
				if (role == "2")
				{
					EmployeeMainForm employeeMainForm = new EmployeeMainForm();
					this.Hide();

					employeeMainForm.workerId = id;

					employeeMainForm.ShowDialog();
					this.Show();
				}
				if (role == "3")
				{
					CustomerMainForm customerMainForm = new CustomerMainForm();
					this.Hide();

					customerMainForm.idU = id;

					customerMainForm.ShowDialog();
					this.Show();
				}
				if (role == "4")
				{
					ProDirectorMainForm proDirectorMainForm = new ProDirectorMainForm();
					this.Hide();
					proDirectorMainForm.ShowDialog();
					this.Show();
				}

			}
			else
			{
				MessageBox.Show("user not found");
					//ShowError();
			}
		}
	}
}
