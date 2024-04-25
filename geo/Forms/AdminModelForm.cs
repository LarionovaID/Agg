using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using geo.Database;
using geo.Database.Entities;

using Microsoft.Extensions.DependencyInjection;

using geo.Services.Interfaces; 

namespace geo.Forms
{
	public partial class AdminModelForm : Form
	{
		private readonly IDb _db;

		public AdminModelForm(IDb db)
		{
			InitializeComponent();
			_db = db;

			/*dataGridView1.DataBindings
			.Add(new Binding("Text", _db.Roles, "Id"));*/
		}

		private void AdminModelForm_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _db.Roles;
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int selectedIndex = dataGridView1.SelectedRows[0].Index;
				DataRowView dataRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;

				if (dataRow != null)
				{
					var key = dataRow.Row["Id"]; // замените YourKeyColumnName на имя ключевого столбца
					if (_db.Roles.Any(r => r.Id == (int)key)) // замените Id на свойство, которое является ключом
					{
						_db.Roles.Remove((int)key);
						_db.SaveChanges(); // сохраняем изменения в базе данных
					}
				}

				// После сохранения изменений в базе данных, удаляем строку из DataGridView
				dataGridView1.Rows.RemoveAt(selectedIndex);
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			_db.SaveChanges();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
