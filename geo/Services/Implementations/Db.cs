using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using geo.Database;
using geo.Database.Entities;
using geo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace geo.Services.Implementations
{
	internal class Db : IDb
	{
		private readonly AppDbContext _db;

		public Db(AppDbContext db)
		{
			_db = db;

			_db.Roles.Load();
			//_db.Users.Load();

		}

		
		// Database
		public IEnumerable<Role> Roles => _db.Roles.ToList();
		public IEnumerable<User> Users => _db.Users.ToList();

		public IEnumerable<CustomerCompany> CustomerCompanies => _db.CustomerCompanies.ToList();

		public IEnumerable<Project> Projects => _db.Projects.ToList();
		public IEnumerable<Area> Areas => _db.Areas.ToList();
		public IEnumerable<Profile> Profiles => _db.Profiles.ToList();
		public IEnumerable<Picket> Pickets => _db.Pickets.ToList();
		public IEnumerable<Measurement> Measurements => _db.Measurements.ToList();


		// Login
		public bool Authenticate(string login, string password)
		{
			return _db.Users
				.Where(x => x.Login == login && x.Password == password)
				.Any();
		}
		public bool IsLoginAlreadyTaken(string login)
		{
			return _db.Users
				.Where(x => x.Login == login)
				.Any();
		}


		public void SaveChanges() => _db.SaveChanges();

		//public void DeleteRow() => ;

	}
}
