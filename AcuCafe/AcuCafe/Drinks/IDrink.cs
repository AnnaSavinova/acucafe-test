using AcuCafe.Toppings;

namespace AcuCafe.Drinks
{
	public interface IDrink
	{
		double BaseCost { get; }
		void AddTopping(ToppingsList topping);
		void Prepare();
		double GetCost();

	}
}
