using System;
using AcuCafe.Toppings;

namespace AcuCafe.Drinks
{
	public sealed class Espresso : Drink
	{
		protected override string Description => "Espresso";
		public override double BaseCost => 1.8;

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
					Toppings.Add(new Chocolate());
					break;
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
