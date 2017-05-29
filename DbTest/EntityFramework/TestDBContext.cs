namespace DbTest.EntityFramework
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class TestDBContext : DbContext
	{
		public TestDBContext()
			: base("name=TestDBContext")
		{
		}

		public virtual DbSet<member> members { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
