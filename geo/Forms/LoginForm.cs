using geo.Database;
using geo.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

using geo.Services.Interfaces;


namespace geo
{
	public partial class LoginForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDb _db;


		public string connStr => tb_dbServer.Text = "...";

		public LoginForm(IServiceProvider serviceProvider, IDb db)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_db = db;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tb_dbServer.Text = "IRYSIK\\SQLEXPRESS";
			tb_dbName.Text = "GeoDb";
		}

		private void lbl_db_Click(object sender, EventArgs e)
		{

		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			var login = tb_Login.Text;
			var password = tb_Password.Text;

			var isSuccessful = _db.Authenticate(login, password);

			if (isSuccessful)
			{
				DialogResult = DialogResult.OK;
				//Close();

				var AdminDataGridForm = _serviceProvider.GetRequiredService<AdminModelForm>();
				AdminDataGridForm.ShowDialog();

				return;
			}

			MessageBox.Show("Ошибка!!!");
		}
	}
}
