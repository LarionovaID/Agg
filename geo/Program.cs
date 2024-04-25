using geo.Database;
using geo.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using geo.Services.Interfaces;
using geo.Services.Implementations;
using System.Data.Common;


namespace geo
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		/// 

		static public IServiceProvider _serviceProvider { get; set; } = null!;


		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			var services = new ServiceCollection();

			services.InitDI();

			_serviceProvider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService<LoginForm>());

		}

		private static void InitDI(this ServiceCollection services)
		{
			services.AddTransient<LoginForm>();
			services.AddTransient<MainForm>();
			services.AddTransient<AdminModelForm>();


			services.AddScoped<IDb, Db>();

			//string loginText = _serviceProvider.GetRequiredService<LoginForm>().connStr;

			//string dataSource = _serviceProvider.GetRequiredService<LoginForm>().connStr;
			//string connectionString = $"Data Source={dataSource};Initial Catalog=GeoDb;Integrated Security=True;Encrypt=False;";
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=IRYSIK\\SQLEXPRESS;Initial Catalog=GeoDb;Integrated Security=True;Encrypt=False;"));

		}
	}
}