using AcuCafe.Drinks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafeTest
{
	[TestClass]
	public class AcuCafeTest
	{
		[TestMethod]
		public void PrepareEspresso()
		{
			var espresso = new Espresso();
			espresso.Prepare();
		}

		[TestMethod]
		public void PrepareTea()
		{
			var tea = new Tea();
			tea.Prepare();
		}

		[TestMethod]
		public void PrepareIceTea()
		{
			var iceTea = new IceTea();
			iceTea.Prepare();
		}

		[TestMethod]
		public void OrderEspresso()
		{
			var drink = AcuCafe.AcuCafe.OrderDrink(DrinkList.Espresso, true, true, true);
			drink.GetCost();
		}

		[TestMethod]
		public void OrderTea()
		{
			var drink = AcuCafe.AcuCafe.OrderDrink(DrinkList.Tea, true, true, false);
			drink.GetCost();
		}

		[TestMethod]
		public void OrderIceTea()
		{
			var drink = AcuCafe.AcuCafe.OrderDrink(DrinkList.IceTea, false, true, false);
			drink.GetCost();
		}

		[TestMethod]
		public void OrderIceTeaWithMilk_ShouldFail()
		{
			var drink = AcuCafe.AcuCafe.OrderDrink(DrinkList.IceTea, true, true, false);
			Assert.IsNull(drink);
		}
	}
}
