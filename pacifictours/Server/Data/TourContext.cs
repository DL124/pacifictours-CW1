using Microsoft.EntityFrameworkCore;
using pacifictours.Shared;

namespace pacifictours.Server.Data
{
	public class TourContext: DbContext
	{
		public TourContext(DbContextOptions<HotelContext> options) : base(options)
		{
		}
		public DbSet<Tour> Tours 
		{ get; set; }

	}
}
