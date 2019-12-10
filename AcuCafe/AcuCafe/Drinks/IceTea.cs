using System;
using AcuCafe.Toppings;

namespace AcuCafe.Drinks
{
	public sealed class IceTea : Drink
	{
		protected override string Description => "Ice tea";
		public override double BaseCost => 1.5;

		public override void AddTopping(ToppingsList topping)
		{
			switch (topping)
			{
				case ToppingsList.Sugar:
					Toppings.Add(new Sugar());
					break;
				case ToppingsList.Milk:
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
