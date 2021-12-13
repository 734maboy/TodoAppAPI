using Microsoft.EntityFrameworkCore;

namespace TodoAppAPI
{
	public class AppContext : DbContext
	{
		public AppContext() {
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoBase;Trusted_Connection=True;");
		}


	}
}
