using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoAppAPI.Models {
	public class Category : BaseModel {
		[Required, MaxLength(30), MinLength(1)]
		public string name { get; set; }
		public List<TodoItem> TodoItems { get; set; }
	}
}
