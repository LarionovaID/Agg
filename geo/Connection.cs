using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo
{
	internal static class Connection
	{
		private static string _connectionString;

		public static void SetConnectionString(string connectionString)
		{
			_connectionString = connectionString;
		}

		public static string GetConnectionString()
		{
			return _connectionString;
		}
	}
}
