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
		//Объявление соединения
		static string connectionStr = "Data Source=DBSRV\\AG2023; Initial Catalog=LarionovaID1_107g2;Integrated Security=True";
		SqlConnection sqlConnection = new SqlConnection(connectionStr);

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

		public SqlConnection GetConnection() 
		{ 
			return sqlConnection;
		}
	}
}
