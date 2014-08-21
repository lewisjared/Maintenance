using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maintenance.Models
{
	public class ModalResponse
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public virtual Question Question { get; set; }
		public string AnswersValue { get; set; }

		[NotMapped]
		public virtual IList<int> Answers
		{
			get { return Array.ConvertAll(AnswersValue.Split(','), int.Parse); }
			set { AnswersValue = string.Join(",", value.ToArray()); }
		}
	}
}