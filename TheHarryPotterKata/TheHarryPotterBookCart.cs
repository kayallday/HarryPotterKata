using NUnit.Framework;
using HarryPotterKata;

namespace TheHarryPotterKata
{
	[TestFixture]
	public class TheHarryPotterBookCart
	{
		private static HarryPotterBookCart shoppingCart;
		[SetUp]
		public void SetUp()
		{
			shoppingCart = new HarryPotterBookCart();
		}
		
		[Test]
		public void Given0BooksTotalIsEqualTo0()
		{;
			var total = shoppingCart.Add();
			Assert.AreEqual(0, total);
		}

		[Test]
		public void Given1BookThenTotalIsEqualTo8()
		{
			var total = shoppingCart.Add("The Sorcerer's Stone");
			Assert.AreEqual(8, total);
		}
	}
}
