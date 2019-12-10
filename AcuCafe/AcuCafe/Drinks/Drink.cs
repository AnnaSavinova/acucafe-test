using System;
using System.Collections.Generic;
using System.Linq;
using AcuCafe.Toppings;

namespace AcuCafe.Drinks
{
	public abstract class Drink : IDrink
	{
		public abstract double BaseCost { get; }
		public abstract void AddTopping(ToppingsList topping);

		public double GetCost()
		{
			return BaseCost + Toppings.Sum(topping => topping.Cost);
		}

		protected string PrepareToppings()
		{
			if (!Toppings.Any())
				return string.Empty;

			var toppingsNames = Toppings.Select(t => t.Name).ToList();
			return $" with {string.Join(", ", toppingsNames)}";
		}

		protected abstract string PrepareBaseDrink();

		public void Prepare()
		{
			var message = PrepareBaseDrink();
			message += PrepareToppings();

			Console.WriteLine(message);
		}


		protected ICollection<ITopping> Toppings = new List<ITopping>();
		protected abstract string Description { get; }
	}
}
