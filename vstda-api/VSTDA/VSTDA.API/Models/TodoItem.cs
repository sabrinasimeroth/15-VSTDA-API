using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSTDA.API.Models
{
	public class TodoItem
	{
		public int TodoItemId { get; set; }

		public string task { get; set; }

		public int priority { get; set; }
	}
}