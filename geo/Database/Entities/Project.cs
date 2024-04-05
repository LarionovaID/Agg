using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Database.Entities
{
	public class Project
	{
		public int Id { get; set; }
		public string Coordinates { get; set; }

		public List<Area> Areas { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int CustomerCompanyId { get; set; }
		public CustomerCompany CustomerCompany { get; set; }
	}
}
