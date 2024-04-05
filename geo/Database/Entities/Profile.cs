using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Database.Entities
{
	public class Profile
	{
		public int Id { get; set; }
		public string Coordinates { get; set; }
		public float Length { get; set; }

		public List<Picket> Pickets { get; set; }

		public int AreaId { get; set; }
		public Area Area { get; set; }
	}
}
