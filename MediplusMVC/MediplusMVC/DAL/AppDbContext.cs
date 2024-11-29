using MediplusMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MediplusMVC.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<SliderItem> SliderItems { get; set; }
	}
}
