using System;
using AcuCafe.Drinks;
using AcuCafe.Toppings;

namespace AcuCafe
{
	public static class AcuCafe
	{
		public static IDrink OrderDrink(DrinkList type, bool hasMilk, bool hasSugar, bool hasChocolateTopping)
		{
			IDrink drink;
			switch (type)
			{
				case DrinkList.Espresso:
					drink = new Espresso();
					break;
				case DrinkList.Tea:
					drink = new Tea();
					break;
				case DrinkList.IceTea:
					drink = new IceTea();
					break;
				default:
					throw new InvalidOperationException($"Unknown drink: {type}");
			}

			try
			{
				if (hasMilk)
					drink.AddTopping(ToppingsList.Milk);
				if (hasSugar)
					drink.AddTopping(ToppingsList.Sugar);
				if (hasChocolateTopping)
					drink.AddTopping(ToppingsList.Chocolate);

				drink.Prepare();
			}
			catch (Exception ex)
			{
				Console.WriteLine("We are unable to prepare your drink.");
				System.IO.File.WriteAllText(@"Error.txt", ex.ToString());
				return null;
			}

			return drink;
		}
	}
}