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

namespace geo_dotnet.Controls.Admin
{
	public partial class AdminsPanel : UserControl
	{
		private Form parentForm;
		public void SetParentForm(Form form)
		{
			parentForm = form;
		}


		public AdminsPanel()
		{
			InitializeComponent();
		}

		private void btn_Users_Click(object sender, EventArgs e)
		{
			AdminUserForm adminUserForm = new AdminUserForm();
			adminUserForm.ShowDialog();

			parentForm?.Close(); // Закрыть родительскую форму при нажатии кнопки 1 (если ссылка не равна null)
		}

		private void btn_Projects_Click(object sender, EventArgs e)
		{
			AdminMainProjectForm adminMainProjectForm = new AdminMainProjectForm();
			adminMainProjectForm.ShowDialog();

			parentForm?.Close(); // Закрыть родительскую форму при нажатии кнопки 1 (если ссылка не равна null)	
		}

		private void UserControl1_Load(object sender, EventArgs e)
		{

		}
	}
}
