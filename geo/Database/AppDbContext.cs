using geo.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using geo.Database.Entities;
using ScottPlot.Colormaps;
using ScottPlot.Plottables;


namespace geo.Database
{
	public class AppDbContext : DbContext
	{
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }

		public DbSet<CustomerCompany> CustomerCompanies { get; set; }

		public DbSet<Project> Projects { get; set; }
		public DbSet<Area> Areas { get; set; }
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<Picket> Pickets { get; set; }
		public DbSet<Measurement> Measurements { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
		}

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.AddInitialData();
		}
	}
	public static class ModelBuilderExtensions
	{
		public static ModelBuilder AddInitialData(this ModelBuilder modelBuilder)
		{
			List<Role> roles = new()
			{
				new Role { Id = 1, Name = "admin" },
				new Role { Id = 2, Name = "user" },
			};


			modelBuilder.Entity<Role>().HasData(roles);
			

			return modelBuilder;
		}
	}
}
