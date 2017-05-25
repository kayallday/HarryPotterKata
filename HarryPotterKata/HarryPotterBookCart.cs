using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterKata
{
	public class HarryPotterBookCart
	{
		List<HarryPotterBook> cart = new List<HarryPotterBook>();
		public decimal Add()
		{
			
			return 0;
		}

		public decimal Add(HarryPotterBook book)
		{
			cart.Add(book);
			return CalculateTotal();
		}
		
		public decimal CalculateTotal()
		{
			var 
		}
	}
}
