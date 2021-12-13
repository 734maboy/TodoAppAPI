using System;
using System.ComponentModel.DataAnnotations;

namespace TodoAppAPI.Models {
	public class TodoItem : BaseModel {
		[Required, MaxLength(50)]
		public string Title { get; set; }
		public string Description { get; set; }
		public Guid StatusId { get; set; }
		public Status Status { get; set; }
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }
		public Guid UserId { get; set; }
		public User User { get; set; }
		public DateTime FinishDate { get; set; }
	}
}
