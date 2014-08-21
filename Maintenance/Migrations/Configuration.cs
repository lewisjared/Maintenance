namespace Maintenance.Migrations
{
	using Maintenance.Models;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using System.Collections.Generic;

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
					Title1="How structured is your maintenance strategy?",
					IsButton=false,
					LowerText= "Organic strategy, unplanned",
					UpperText= "Long-term strategy with full documentation",
					Class = "question1",
					ModalName = "question1Modal",
					NextItem = "question2"
				},
				new Question
				{
					QuestionId = 2,
					Title1="What is your/your staff’s attitude towards maintenance?",
					IsButton=false,
					LowerText= "Necessary evil",
					UpperText= "Integral, profit-maximising activity",
					Class = "question2",
					ModalName = "question2Modal",
					NextItem = "question3"
				},
				new Question
				{
					QuestionId = 3,
					Title1="How often do you review your maintenance strategy/activities?",
					IsButton=false,
					LowerText= "Never",
					UpperText= "Continually, with operations and business plans",
					Class = "question3",
					ModalName = "question3Modal",
					NextItem = "question4"
				},
				new Question
				{
					QuestionId = 4,
					Title1 = "What proportion of your maintenance activities are outsourced to contractors?",
					IsButton = false,
					LowerText = "None - all done in house",
					UpperText = "All outsourced",
					Class = "question4",
					ModalName = "question4Modal",
					NextItem = "question5"
				},
				new Question
				{
					QuestionId = 5,
					Title1 = "How integrated is your asset management system with other business activities?",
					IsButton = false,
					LowerText = "None - maintenance operates in a silo",
					UpperText = "Fully integrated in Business Excellence and strategic plans",
					Class = "question5",
					ModalName = "question5Modal",
					NextItem = "question6"
				},
				new Question
				{
					QuestionId = 6,
					Title1 = "",
					IsButton = false,
					LowerText = "",
					UpperText = "All outsourced",
					Class = "question6",
					ModalName = "question6Modal",
					NextItem = "question7"
				},
				new Question
				{
					QuestionId = 7,
					Title1 = "How much do regulations and public perception influence your maintenance decisions?",
					IsButton = false,
					LowerText = "Not much",
					UpperText = "A lot",
					Class = "question7",
					ModalName = "question7Modal",
					NextItem = "question8"
				},
				new Question
				{
					QuestionId = 8,
					Title1="What is your most commonly used Maintenance Method?",
					IsButton=true,
					ButtonText= new List<ButtonText>{
						new ButtonText {Text="Run to Failure", Value=1},
						new ButtonText {Text="Time Based", Value=2},
						new ButtonText {Text="Opportunity", Value=3},
						new ButtonText {Text="Design Out", Value=4},
						new ButtonText {Text="Condition Based", Value=5}
					},
					Class = "question8",
					ModalName = "question8Modal",
					NextItem = "question9",
				},
				new Question
				{
					QuestionId = 9,
					Title1 = "What level of non-specification failure do you tolerate?",
					IsButton = false,
					LowerText = "None",
					UpperText = "A lot",
					Class = "question9",
					ModalName = "question9Modal",
					NextItem = "question10"
				},
				new Question
				{
					QuestionId = 10,
					Title1 = "How important are environmental considerations in your maintenance and disposal strategies?",
					IsButton = false,
					LowerText = "Not much",
					UpperText = "A lot",
					Class = "question10",
					ModalName = "question10Modal",
					NextItem = "question11"
				},
				new Question
				{
					QuestionId = 11,
					Title1 = "When making CapEx purchases, do you consider maintenance in the life cycle cost (LCC)?",
					IsButton = false,
					LowerText = "Not at all",
					UpperText = "Full life cycle analysis",
					Class = "question11",
					ModalName = "question11Modal",
					NextItem = "submit"
				}
			);

			context.SaveChanges();

			context.ModalResponses.AddOrUpdate(
				r => r.Id,
				new ModalResponse
				{
					Id=1,
					Title="Run to Failure Maintenance",
					Content="<p>With run-to-failure maintenance the plant item is allowed to fail before maintenance is initiated. This method is only an appropriate method when the consequences of the plant failure are small. Appropriate use of this method is when:</p><ul><li>the plant item is unimportant or not crucial to production</li><li>Repair maintenance will not take long&nbsp;</li><li>Complete failure will not result in significant cost</li><li>Failure is not practically predictable using instrumental or analysis&nbsp;</li></ul>",
					Question = context.Questions.Single(q=> q.QuestionId==8),
					Answers = new List<int> {1}
				},
				new ModalResponse
				{
					Id = 2,
					Title = "Time based Maintenance",
					Content = "<p>Time based Maintenance is planned or time based preventative maintenance that is implemented in advance to prevent failure of plant. It assumes that machine and component life is predictable and maintenance is based on hours run; it focuses on preventing failure through replacing components at particular times in individual or block replacements. Time based Maintenance is a good method if the assumptions are correct.</p><p>Advantages</p><ul><li>A more effective use of time</li><li>Spare are only ordered as required</li></ul><p>Disadvantages</p><ul><li>Plant may not fail according to fixed time period</li><li>Failures may still occur</li><li>Depends on statistical analysis; in many cases suitable and correct failure data are not present</li><li>May not need maintaining</li><li>Unnecessary strip down may cause problems</li></ul>",
					Question = context.Questions.Single(q=> q.QuestionId==8),
					Answers = new List<int> { 2 }
				},
				new ModalResponse
				{
					Id = 3,
					Title = "Opportunity Maintenance",
					Content = "<p>Opportunity Maintenance is an extension of Time based maintenance and is the planning of maintenance around an opportunity for access for the particular plant. Plant that is maintained using Opportunity Maintenance methods is often run continuously and therefore must be deliberately shut down in order to be maintained. A good example of this is Meridian emptying a portion of its canal system over the Christmas period when energy generation is low for maintenance. The method relies on statistical data to establish whether repairs are required now or at the next shutdown. Opportunities can arise from either a planned or unscheduled event.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==8),
					Answers = new List<int> { 3 }
				},
				new ModalResponse
				{
					Id = 4,
					Title = "Design out Maintenance",
					Content = "<p>The Design out maintenance method means that a failure is addressed by a new or updated design process, with the intention of reducing or preventing the future failure. The strategy should be combined with others as usually design out is undertaken to reduce repeat failures and preventative maintenance is still required.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==8),
					Answers = new List<int> { 4 }
				},
				new ModalResponse
				{
					Id = 5,
					Title = "Condition Based Maintenance",
					Content = "<p>Condition based maintenance plans avoid failure by detecting early deterioration, and identifying hidden or potential failure. The component or equipment is usually replaced or repaired as soon as the monitoring level value exceeds the normal range. CBM combines the advantages of a number of other strategies.</p><p>Advantages</p><ul><li>Better planning of repairs is possible</li><li>Inconvenient breakdowns and expensive consequential damages is avoided</li><li>The failure rate is reduced, thus improving availability and reliability</li><li>Reduced spares and inventory is required</li><li>Unnecessary work is avoided, keeping the repair team small but highly skilled</li></ul><p>Disadvantages</p><ul><li>Some techniques are expensive</li><li>Should only be applied to critical plant based on capital value, safety and potential for production loss</li></ul>",
					Question = context.Questions.Single(q=> q.QuestionId==8),
					Answers = new List<int> { 5 }
				},
				new ModalResponse
				{
					Id = 6,
					Title = "Condition Based Maintenance",
					Content = "<p>Snap out of it!</p><p>Until recently maintenance has been largely viewed as a non-profit activity. We know that the role of maintenance is to maximise the efficient utilisation of assets. We also know that organisations control and use assets to gain some value, and ultimately make a profit! It stands to reason that maintenance    should be considered a profit activity, and indeed this attitude shift has been documented (Garg &amp; Deshmukh, 2006).<br/></p><p>    <br/>    Systems maintenance strategies, such as Total Productive Maintenance, have been veritably successful. Implementation of these programmes necessitate a staff culture shift towards understanding and acknowledging the importance of maintenance (Ahuja &amp; Khamba, 2008). This is particularly important where    staff turnover might dilute the effectiveness of such strategies in the long run. Therefore, it is essential that ALL staff drop the poor maintenance    attitude.    <br/></p><p>    <br/>    We recommend you make this task a priority. For guidance, see Section 5.5 of Asset Management - an anatomy (version 2), The Institute of Asset Management    (2014).</p>",
					Question = context.Questions.Single(q=> q.QuestionId==2),
					Answers = new List<int> { 1, 2, 3 }
				},
				new ModalResponse
				{
					Id = 7,
					Title = "Condition Based Maintenance",
					Content = "<p>Great stuff! Your organisation understands the importance of maintenance in all business activities, and how it contributes to your bottom line.</p><p>Remember that continuous improvement will only be achieved if the staff have a positive attitude towards asset maintenance (Ahuja & Khamba, 2008). Keep an eye on how this develops over time and with staff turnover.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==2),
					Answers = new List<int> { 4, 5 }
				},
				new ModalResponse
				{
					Id = 8,
					Title = "Condition Based Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==3),
					Answers = new List<int> { 1,2,3 }
				},
				new ModalResponse
				{
					Id = 9,
					Title = "Condition Based Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==3),
					Answers = new List<int> { 4, 5 }
				},
				new ModalResponse
				{
					Id = 9,
					Title = "In House Maintenance",
					Content = "<p>You must be an engineer&hellip;</p><p>But seriously, that&rsquo;s great! Brent Wilson, the Engineering Strategy Manager at Meridian Energy agrees. At Meridian, almost all maintenance activities are done internally, which develops the staff &ldquo;know-how&rdquo; and creates a greater sense of ownership of staff towards those assets. Your staff will be ready and able to sort out problems as soon as they arise, and you&rsquo;ll save costs and logistics issues by avoiding contractors (Brent Wilson, personal communication).</p><p>On the other hand, more and more businesses are finding that contracting out maintenance allows them to focus their efforts on their core competencies, and increase overall efficiencies (Garg &amp; Deshmukh, 2006; The Institute of Asset Management, 2014). With increasingly sophisticated assets you may find that outsourcing complicated maintenance tasks pays dividends. We recommend you review your strategy regularly with this in mind.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==4),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 10,
					Title = "Out Sourcing Maintenance",
					Content = "<p>It looks like you&rsquo;ve been doing your homework!</p><p>There is a trend towards maintenance outsourcing, particularly where high technology assets are involved (Garg &amp; Deshmukh, 2006). This allows the organisation to focus on what they do best, and leave maintenance to the experts. The direct cost may be greater, but efficiency gains will benefit you in the long run.</p><p>But have you ever thought that the maintenance contracting process leaves a lot to be desired? Normal contracting procedures are prone to budget and schedule overruns, poor work quality, and inadequate maintenance design to reduce the life cycle cost of an asset. Luckily there&rsquo;s a better system - performance based maintenance by contracting (PBMC) - whereby contractors are held accountable to a longer-term set of standard performance requirements. PBMC has been shown in several countries (including New Zealand) to improve efficiencies to reduce costs by 10-50%, particularly in the roading industry (Sultana, Rahman &amp; Chowdhury, 2012).</p><p>So make sure maintenance contractors operate to standards aligned with your business goals, and keep an eye out for new developments in maintenance outsourcing strategies.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==4),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 11,
					Title = "In House Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==5),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 12,
					Title = "Out Sourcing Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==5),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 13,
					Title = "In House Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==6),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 14,
					Title = "Out Sourcing Maintenance",
					Content = "",
					Question = context.Questions.Single(q=> q.QuestionId==6),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 15,
					Title = "In House Maintenance",
					Content = @"<p>Regulations and public perception should be at the forefront of business planning.</p>
				<p>Regulatory bodies are constantly updating the practises that must be adhered to, which can often add a large amount of cost and complexity to a process (Maintenance Maven, 2011). While this is the case, there is a trend for businesses to have more of a focus on meeting regulatory standards to avoid future liabilities and associated costs (Stone, 2014).</p>
				<p>Having these regulations in place sets a clear scope of what is expected of businesses. Previous to the introduction of such regulations in 1992 (Maintenance Engineering Society of New Zealand, 2014), engineers were responsible for defining this, leading to risk exposure of the company if an event did occur. There is a trend for engineers to be involved with the setting of regulations due to the in depth knowledge that was gained through operation.</p>
				<p>There is also a trend for businesses to become accredited in various standards as a way to gain credibility with the public. ISO and LEED (Leadership in Energy and Environmental Design) are examples of this trend (Maintenance Maven, 2011). While these standards often have a high associated cost and large paper trail, depending on the space in which the business is operating, this may be an appropriate step to be taken (Reliability Web, 2014).</p>",
					Question = context.Questions.Single(q=> q.QuestionId==7),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 16,
					Title = "Out Sourcing Maintenance",
					Content = "<p>This is a good place to be! Currently, businesses are following this trend to meet regulations, saving huge sums of money in potential liability.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==7),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 17,
					Title = "Fault Tolerance",
					Content = "<p>You obviously have a high degree of focus on quality. Depending on your industry, this may not be wise, but trends show that the majority of manufacturing is heading towards higher quality.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==9),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 18,
					Title = "Fault Tolerance",
					Content = @"<p>If your business does not run on quality, this may be the best space for your business to operate in. However, some things that could be adopted are as follows:</p>
<p>There are a variety of quality management tools that can be utilised to reduce the number of defects in products. Examples of these are Six Sigma, lean manufacturing and Total Productive Management (TPM).</p>
<p>Six Sigma is a project based, quantitative method utilising statistical data to assess the performance of a process. It strives for less than 3.4 defects per million products. Improvements are made through six steps (Sigma, 2014):</p>
<ul>
	<li>Defining</li>
	<li>Measuring</li>
	<li>Analysing</li>
	<li>Improving</li>
	<li>Controlling</li>
</ul>
<p>The Six Sigma Academy states that companies can save around $230,000 per project through improvements. This process can be implemented in conjunction with lean manufacturing. Lean is a way of operating a business in that areas in the business that are not adding value are eliminated. This, in turn can allow the business to place a greater focus on increasing the quality of its products. Lean also can implement Jidoka or Pokayoke systems in which a defective, or non-standard product is identified (Lean Manufacturing Tools, 2014). This can either highlight the event or stop the defect from occurring in the first place.</p>
<p>TPM is a way of ensuring product quality through scheduling regular preventative maintenance and keeping emergency maintenance to a minimum (Venkatesh, 2007). It acts highlight maintenance as a profit activity for the business.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==9),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 19,
					Title = "Environmental Considerations",
					Content = @"<p>You should stop what you are doing and rethink your business model!</p>
<p>A factor that has previously often been ignored in manufacturing is producing with respect to the environment. However, there is an increasing trend for businesses to design for the full life cycle of their product. While achieving economic growth while protecting the environment is inherently contradictory, increased regulations and potential law suits have made this process more and more important.</p>
<p>The practises that should be adopted are dependent on the processes and products that the company uses. Wastes could include: toxic materials, waste and wastewater, emissions, greenhouse gases, energy usage and material recycling (Allen et al., 2002). Cultural, geographic and business needs are huge influences in whether practises are adopted by the company.</p>
<p>Life-Cycle Assessment is a useful tool to assess the impact that processes have on the environment and can help to identify areas for change (United States Environmental Protection Agency, 2013).</p>",
					Question = context.Questions.Single(q=> q.QuestionId==10),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 20,
					Title = "Environmental Considerations",
					Content = "<p>Great! May your business prosper into the future.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==10),
					Answers = new List<int> { 3, 4, 5 }
				},
				new ModalResponse
				{
					Id = 21,
					Title = "Life Cycle Analysis",
					Content = @"<p>If you don&rsquo;t change soon, your business could face massive problems in the future.</p>
<p>This is a fundamental step that should be taken when considering purchasing new equipment. Some equipment may have a low up front cost, but a large maintenance cost associated with its use.</p>
<p>Therefore, it is imperative to consider the total cost of the equipment. Depending on the type and quality of the equipment, maintenance can range from 1-20% of the Asset Replacement Value (ARV) (Lifetime Reality, 2014). The company must be aware of the total cost of equipment as if maintenance is not well managed, the costs can cripple a business (Maintenance Resources, 2011).</p>",
					Question = context.Questions.Single(q=> q.QuestionId==11),
					Answers = new List<int> { 1,2 }
				},
				new ModalResponse
				{
					Id = 22,
					Title = "Life Cycle Analysis",
					Content = "<p>Great! You obviously have a handle on smart costing decisions.</p>",
					Question = context.Questions.Single(q=> q.QuestionId==11),
					Answers = new List<int> { 3, 4, 5 }
				}
			);
			context.SaveChanges();
		
		}
	}
}