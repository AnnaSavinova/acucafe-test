using System;
using AcuCafe.Toppings;

namespace AcuCafe.Drinks
{
	public sealed class Tea : Drink
	{
		protected override string Description => "Hot tea";
		public override double BaseCost => 1;

		public override void AddTopping(ToppingsList topping)
		{
			switch (topping)
			{
				case ToppingsList.Milk:
					Toppings.Add(new Milk());
					break;
				case ToppingsList.Sugar:
					Toppings.Add(new Sugar());
					break;
				case ToppingsList.Chocolate:
					throw new InvalidOperationException($"Illegal topping for {Description}: {topping}");
				default:
					throw new InvalidOperationException($"Unknown topping: {topping}");
			}
		}

		protected override string PrepareBaseDrink()
		{
			return "We are preparing the following drink for you: " + Description;
		}
	}
}
