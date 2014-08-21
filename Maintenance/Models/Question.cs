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
		public bool IsButton { get; set; }
		virtual public List<ButtonText> ButtonText { get; set; }
		public string LowerText { get; set; }
		public string UpperText { get; set; }

		public string Class { get; set; }
		public string ModalName { get; set; }
		public string NextItem { get; set; }
	}

	public class ButtonText
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public int Value { get; set; }
	}
}
