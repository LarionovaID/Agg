using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geo_dotnet.Forms.Customer
{
	public partial class CustomerMainForm : Form
	{
		public int idU {  get; set; }


		public CustomerMainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CustProjForm custProjForm = new CustProjForm();

			int id = this.idU;
			custProjForm.userId = id;

			custProjForm.ShowDialog();
		}

		private void CustomerMainForm_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
