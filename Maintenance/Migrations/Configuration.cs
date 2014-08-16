namespace Maintenance.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using Maintenance.Models;
	using WebMatrix.WebData;
	using System.Web.Security;

	internal sealed class Configuration : DbMigrationsConfiguration<Maintenance.Models.EntityContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
			ContextKey = "Maintenance.Models.EntityContext";
		}

		protected override void Seed(Maintenance.Models.EntityContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
			//if (System.Diagnostics.Debugger.IsAttached == false)
			//   System.Diagnostics.Debugger.Launch();

			context.Questions.AddOrUpdate(
				q => q.QuestionId,
				new Question
				{
					QuestionId = 1,
					Title1 = "Disposable",
					Title2 = "Long term",
					Desc1 = "Do you buy equipment that is cheap and disposable or spend more on long lasting equipment?",
					Desc2 = "Do you factor in disposal, decommissioning, recycling or upcycling costs",
					Class = "question1",
					NextItem = "question2"
				},
				new Question
				{
					QuestionId = 2,
					Title1 = "Low Maintenance design",
					Title2 = "Low Capital, Higher Maintenance",
					Desc1 = "Do you prefer to spend capital up front on assets that require little maintenance or purchase a poorer quality asset and spread the cost over the life of the item through maintenance",
					Desc2 = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc, Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus",
					Class = "question2",
					NextItem = "question3"
				},
				new Question
				{
					QuestionId = 3,
					Title1 = "In-house Maintenance",
					Title2 = "External Maintenance",
					Desc1 = " Do you prefer to have maintenance in-house or outhouse?",
					Desc2 = "Does your business prioritise internal knowledge over cost?",
					Class = "question3",
					NextItem = "question4"
				},
				new Question
				{
					QuestionId = 4,
					Title1 = "Strategy",
					Title2 = "Organic",
					Desc1 = " Do you have defined roles in terms of maintenance or encourage personal initiative?",
					Desc2 = "Do you have a defined strategy or does the situation influence the maintenance strategy taken?",
					Class = "question4",
					NextItem = "question5"
				},
				new Question
				{
					QuestionId = 5,
					Title1 = "Financial Gains",
					Title2 = "Conscious Capitalism",
					Desc1 = " Is profit the biggest driver of success within the company?",
					Desc2 = "Are there quality programmes with a staff focus in place in the business?",
					Class = "question5",
					NextItem = "submit"
				});
			context.SaveChanges();

		}
	}
}