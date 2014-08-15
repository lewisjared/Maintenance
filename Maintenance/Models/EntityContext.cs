using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Maintenance.Models
{
	public class EntityContext : DbContext
	{
		public EntityContext()
			: base("name=EntityContext")
		{
		}

		public DbSet<Question> Questions { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

		}
	}
}