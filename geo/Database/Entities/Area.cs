using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace geo.Database.Entities
{
	public class Area
	{
		public int Id { get; set; }
		public string Coordinates { get; set; }
		public float Size { get; set; }

		public List<Project> Projects { get; set; }

		public List<Profile> Profiles { get; set; }


	}
}
