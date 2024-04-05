using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Database.Entities
{
	public class User
	{

		public int Id { get; set; }
		public string FIO { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }


		public int RoleId { get; set; }
		public Role Role { get; set; }

		public List<Measurement> Measurements { get; set; }

		public List<Project> Projects { get; set; }

		public List<CustomerCompany> CustomerCompanies { get; set; }
	}
}
