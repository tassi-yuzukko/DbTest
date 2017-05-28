using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest
{
	class LinqToSqlTest
	{
		public void RunLinq()
		{
			var db = new LinqToSql.LinqToSqlTestDataContext();

			var query = from n in db.members where n.name == "hoge" select n;

			foreach(var m in query)
			{
				Console.WriteLine("{0} {1} {2}", m.id, m.birthday, m.name);
			}
		}
	}
}
