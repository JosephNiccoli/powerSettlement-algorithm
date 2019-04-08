using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PowerSettlement.Models;

namespace PowerSettlement.Controllers
{
	[RoutePrefix("api/test")]
	public class TestController : System.Web.Http.ApiController
	{
		// weight has to be between 1.1 and 3.0 and can only carry 2 bags at a time and you want to see how many least amount
		// of trips it will take to carry all the bags in

		[HttpGet, Route("getall")]
		public List<float> PowerSettlement()
		{
			List<float> bagWeight = new List<float>();


			bagWeight.Add(1.1f);
			bagWeight.Add(1.3f);
			bagWeight.Add(1.9f);
			bagWeight.Add(2.7f);
			bagWeight.Add(1.6f);


			//bagWeight = bagWeight.OrderByDescending(p => p).ToList(); // descending Order

			bagWeight.Sort(); // ascending order
							
							  //Without Linq

			//li.Sort((a, b) => a.CompareTo(b)); // ascending sort
			//li.Sort((a, b) => -1 * a.CompareTo(b)); // descending sort

			return bagWeight;
		}

		private List<float> BagWeights(List<float> bagWeight)
		{
			var BagCount = 0;

			foreach (var x in bagWeight)
			{
				if (x > 2.0)
					BagCount++;
				foreach (var y in bagWeight)
				{
					if (x == y)
						continue;

					if (x + y <= 3)
					{
						BagCount++;
					}
				}
			};
			return BagCount;
		}
	}
}
