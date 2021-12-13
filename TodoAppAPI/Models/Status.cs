using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoAppAPI.Models {
	public class Status : BaseModel {
		[Required, MinLength(1), MaxLength(20)]
		public string Name { get; set; }	
		public List<TodoItem> TodoItems { get; set; }
	}
}
