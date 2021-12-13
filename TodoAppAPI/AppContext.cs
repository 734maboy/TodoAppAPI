using Microsoft.EntityFrameworkCore;
using System;
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
		/// <summary>
		/// Заполнение базы данными
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			//modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Tom", Age = 36 });
			modelBuilder.Entity<Category>().HasData(new Category[] {
				new Category { Id = Guid.NewGuid(), Name = "Учеба" },
				new Category { Id = Guid.NewGuid(), Name = "Дом" },
				new Category { Id = Guid.NewGuid(), Name = "Работа" },
			});
			modelBuilder.Entity<Status>().HasData(new Status[] {
				new Status { Id = Guid.NewGuid(), Name = "Заморожено"},
				new Status { Id = Guid.NewGuid(), Name = "Выполняется"},
				new Status { Id = Guid.NewGuid(), Name = "Выполнено"},
			});
			modelBuilder.Entity<User>().HasData(new User {
				Id = Guid.NewGuid(),
				Name = "734su",
				Login = "TeaIT",
				Password = "letmeseeurcode",
			});
		}

	}
}
