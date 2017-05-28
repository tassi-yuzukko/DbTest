using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DbTest
{
	class AdoNetTest
	{
		/// <summary>
		/// 接続型テスト
		/// </summary>
		/// <param name="connectionString"></param>
		public void ConnectionTest(string connectionString)
		{
			SqlConnection conn = new SqlConnection();
			SqlCommand command = new SqlCommand();

			conn.ConnectionString = connectionString;
			try
			{
				conn.Open();
				Console.WriteLine("接続成功！ : " + conn.ConnectionString);

				command.Connection = conn;
				command.CommandText = "SELECT * FROM dbo.members";

				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine("id:{0} name:{1}", reader["name"], reader["birthday"]);
				}

				conn.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}

		/// <summary>
		/// 日接続型テスト
		/// </summary>
		/// <param name="connectionString"></param>
		public void ConnectionLessTest(string connectionString)
		{
			SqlConnection conn = new SqlConnection();
			SqlCommand command = new SqlCommand();
			SqlDataAdapter adapter = new SqlDataAdapter();
			DataSet ds = new DataSet();

			conn.ConnectionString = connectionString;
			command.Connection = conn;
			command.CommandText = "SELECT * FROM dbo.members";

			adapter.SelectCommand = command;
			adapter.Fill(ds);

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				Console.WriteLine("id:{0} name:{1}", row["name"], row["birthday"]);
			}
		}
	}
}
