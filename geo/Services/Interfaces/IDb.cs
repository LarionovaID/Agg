using geo.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo.Services.Interfaces
{
	public interface IDb
	{
		// Database
		public IEnumerable<Role> Roles { get; }
		public IEnumerable<User> Users { get; }

		public IEnumerable<CustomerCompany> CustomerCompanies { get; }

		public IEnumerable<Project> Projects { get; }
		public IEnumerable<Area> Areas { get; }
		public IEnumerable<Profile> Profiles { get; }
		public IEnumerable<Picket> Pickets { get; }
		public IEnumerable<Measurement> Measurements { get; }


		// Login
		public bool IsLoginAlreadyTaken(string login);
		public bool Authenticate(string login, string password);


		public void SaveChanges();

		//public void DeleteRow();

	}
}
