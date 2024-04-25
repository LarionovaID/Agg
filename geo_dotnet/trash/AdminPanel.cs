using geo_dotnet.Controls.Admin;
using geo_dotnet.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geo_dotnet.Controls
{
	public partial class AdminPanel : UserControl
	{
		private readonly Form parentForm;

		public AdminPanel(Form parentForm)
		{
			InitializeComponent();

			this.parentForm = parentForm;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AdminUserForm adminUserForm = new AdminUserForm();
			adminUserForm.ShowDialog();
			parentForm.Close(); // Закрыть родительскую форму
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AdminMainProjectForm adminMainProjectForm = new AdminMainProjectForm();
			adminMainProjectForm.ShowDialog();
			parentForm.Close(); // Закрыть родительскую форму
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{

		}
	}
}
