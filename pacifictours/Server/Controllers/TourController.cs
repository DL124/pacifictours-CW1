using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pacifictours.Server.Data;
using pacifictours.Shared;

namespace pacifictours.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    public class TourController : ControllerBase
    {
        private readonly HotelContext _context;
        public TourController(HotelContext context)
        {
            _context = context;
        }


        public async Task<ActionResult<List<Tour>>> GetAllTours()
        {

            var list = await _context.Tour.ToListAsync();
            return Ok(list);


        }
    }

}

