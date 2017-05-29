using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kei\testdb.mdf;Integrated Security=True;Connect Timeout=30";
			AdoNetTest adonet = new AdoNetTest();

			// 接続型
			adonet.ConnectionTest(connectionString);

			// 非接続型
			adonet.ConnectionLessTest(connectionString);

			// LinqToSqlの実行
			LinqToSqlTest linqToSql = new LinqToSqlTest();
			linqToSql.RunLinq();

			// EntityFrameworkの実行
			EntityFrameworkTest entityFramework = new EntityFrameworkTest();
			entityFramework.RunEntityFramework();

			Console.ReadKey();

		}

	}
}
