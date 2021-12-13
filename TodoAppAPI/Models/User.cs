using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoAppAPI.Models {
	public class User : BaseModel {
		[Required, MaxLength(40), MinLength(3)]
		public string Name { get; set; }
		[Required,MaxLength(20), MinLength(6)]
		public string Login { get; set; }
		[Required, MaxLength(20), MinLength(6)]
		public string Password { get; set; }
		public List<TodoItem> TodoItems { get; set; }
	}
}
