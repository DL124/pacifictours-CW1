﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pacifictours.Server.Data;
using pacifictours.Shared;

namespace pacifictours.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HotelController : ControllerBase
	{
		private readonly DataContext _context;
		public HotelController(DataContext context)
		{
			_context = context;
		}


		public async Task<ActionResult<List<Hotel>>> GetAllHotels()
		{

			var list = await _context.Hotels.ToListAsync();
			return Ok(list);
			

		}
	}
}
