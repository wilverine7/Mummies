using System;
using Microsoft.EntityFrameworkCore;
namespace Mummies.Models
{
	public class MummiesDbContext : DbContext
    {
		public MummiesDbContext(DbContextOptions<MummiesDbContext> options) : base (options) 
		{

		}

		public DbSet<> Recipes { get; set; }
	}
}

