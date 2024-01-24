using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pacifictours.Server.Data;
using pacifictours.Shared;

namespace pacifictours.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly DataContext _context;
		public OrderController(DataContext context)
		{
			_context = context;
		}


		public async Task<ActionResult<List<Order>>> GetAllOrders()
		{

			var list = await _context.CustomerOrder.ToListAsync();
			return Ok(list);


		}
	}
}
