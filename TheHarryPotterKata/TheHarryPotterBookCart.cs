using NUnit.Framework;
using HarryPotterKata;

namespace TheHarryPotterKata
{
	[TestFixture]
	public class TheHarryPotterBookCart
	{
		//private HarryPotterBookCart shoppingCart;
		//[SetUp]
		//public void SetUp()
		//{
		//	shoppingCart = new HarryPotterBookCart();
		//}
		
		//[Test]
		//public void Given0BooksTotalIsEqualTo0()
		//{
		//	var total = shoppingCart.Add();
		//	Assert.AreEqual(0, total);
		//}
		[Test]
		public void Given0BooksTotalIsEqualTo0()
		{
			var shoppingCart = new HarryPotterBookCart();
			var total = shoppingCart.Add();
			Assert.AreEqual(0, total);
		}

		[Test]
		public void Given1BookThenTotalIsEqualTo8()
		{
			var shoppingCart = new HarryPotterBookCart();
			var total = shoppingCart.Add("The Sorcerer's Stone");
			Assert.AreEqual(8, total);
		}
	}
}
