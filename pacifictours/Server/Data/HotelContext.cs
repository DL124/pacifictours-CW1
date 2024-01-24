using Microsoft.EntityFrameworkCore;
using pacifictours.Shared;

namespace pacifictours.Server.Data
{
	public class HotelContext: DbContext
	{
		public HotelContext(DbContextOptions<HotelContext> options) : base(options)
		{
		}
		public DbSet<Hotel> Hotels 
		{ get; set; }

	}
}
