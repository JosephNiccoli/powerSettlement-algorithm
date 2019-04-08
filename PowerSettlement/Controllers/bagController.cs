using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PowerSettlement.Models;

namespace PowerSettlement.Controllers
{
	public class BagController : Controller
	{

		// weight has to be between 1.1 and 3.0 and can only carry 2 bags at a time and you want to see how many least amount
		// of trips it will take to carry all the bags in

		[HttpGet]
		public ActionResult PowerSettlement()
		{
			List<float> bagWeight = new List<float>();


			bagWeight.Add(1.1f);
			bagWeight.Add(1.3f);
			bagWeight.Add(1.9f);
			bagWeight.Add(2.7f);
			bagWeight.Add(1.6f);

			BagWeights(bagWeight);

		//bagWeight  = bagWeight.OrderBy(p => p).ToList();

		bagWeight.Sort();
		

			return View(new Bag() {BagWeight = bagWeight});
		}

		private List<float> BagWeights(List<float> bagWeight)
		{
			
			return bagWeight;
		}

	}
}