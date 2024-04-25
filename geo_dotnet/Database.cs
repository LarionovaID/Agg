using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace geo_dotnet
{
	internal class Database
	{
		// Объявление соединения
		//public SqlConnection sqlConnection;

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=IRYSIK\SQLEXPRESS;Initial Catalog=GeoDb;Integrated Security=True");

		public SqlConnection GetConnection(/*string serverName, string dbName*/)
		{
			/*
			string _serverName = "IRYSIK\\SQLEXPRESS";
			string _dbName = "GeoDb";

			string connectionStr = $"Data Source={_serverName}; Initial Catalog={_dbName};Integrated Security=True";
			sqlConnection = new SqlConnection(connectionStr);
			*/

			return sqlConnection;
		}

		public void OpenConnection()
		{
			if(sqlConnection.State == System.Data.ConnectionState.Closed)
			{
				sqlConnection.Open();
			}
		}

		public void CloseConnection()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Open)
			{
				sqlConnection.Close();
			}
		}


	}
}
