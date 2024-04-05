using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Database.Entities
{
	public class Picket
	{
		public int Id { get; set; }
		public DateTime DateStatr { get; set; }
		public DateTime DateEnd { get; set; }
		public string Description { get; set; }

		public List<Measurement> Measurements { get; set; }

		public int ProfileID { get; set; }
		public Profile Profile { get; set; }
	}
}
