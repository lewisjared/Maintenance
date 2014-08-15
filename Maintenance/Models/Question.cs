using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maintenance.Models
{
	public class Question
	{
		public int QuestionId { get; set; }

		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string Desc1 { get; set; }
		public string Desc2 { get; set; }

		public string Class { get; set; }
		public string NextItem { get; set; }
	}
}