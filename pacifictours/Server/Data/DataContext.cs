using Microsoft.EntityFrameworkCore;
using pacifictours.Shared;

namespace pacifictours.Server.Data
{
	public class DataContext: DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
		public DbSet<Hotel> Hotels 
		{ get; set; }

        public DbSet<Tour> Tours
        { get; set; }

    }
}
