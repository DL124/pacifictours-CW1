using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacifictours.Shared
{
	public class Tour
	{
		public int Id { get; set; }
		[Required]
		
		public required string tourname { get; set; }

		public int price { get; set; }

		public int spaces { get; set; }


	}
}
