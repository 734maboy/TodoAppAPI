using Microsoft.EntityFrameworkCore;
using TodoAppAPI.Models;

namespace TodoAppAPI
{
	public class AppContext : DbContext
	{

		public DbSet<Category> Categories { get; set; }
		public DbSet<TodoItem> TodoItems { get; set; }
		public DbSet<Status> Statuses { get; set; }
		public DbSet<User> Users { get; set; }
		public AppContext() {
			Database.EnsureCreated();
		}
		/// <summary>
		/// Настройка подключения к БД
		/// </summary>
		/// <param name="optionsBuilder"></param>
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoBase;Trusted_Connection=True;");
		}


	}
}
