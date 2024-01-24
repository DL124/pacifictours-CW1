using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacifictours.Shared
{
	public class Hotel
	{
		public int Id { get; set; }
		[Required]
		
		public string name { get; set; }
		public int singleprice {  get; set; }

		public int doubleprice { get; set; }

		public int familyprice { get; set; }

		public int rooms { get; set; }


	}
}
