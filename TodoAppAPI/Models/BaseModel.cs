using System;
using System.ComponentModel.DataAnnotations;

namespace TodoAppAPI.Models {
	public class BaseModel {
		[Key, Required]
		public Guid Id { get; set; }
	}
}
