using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTest.EntityFramework;

namespace DbTest
{
	class EntityFrameworkTest
	{

		public void RunEntityFramework()
		{
			using (var db = new TestDBContext())
			{
				var query = db.members.Where(m => m.name == "hoge");

				foreach(var m in query)
				{
					Console.WriteLine("{0} {1} {2}", m.id, m.birthday, m.name);
				}
			}
		}
	}
}
