using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Database.Entities
{
	public class Measurement
	{

		public int Id { get; set; }

		public string DataMeasurement { get; set; }

		public DateTime DateTimeMeas { get; set; }


		public int PicketId { get; set; }
		public Picket Picket { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}
