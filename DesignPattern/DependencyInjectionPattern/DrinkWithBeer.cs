using System;
namespace DesignPattern.DependencyInjectionPattern
{
	public class DrinkWithBeer
	{
		private Beer _beer;
		private decimal _water;
		private decimal _sugar;

		public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
		{
			_water = water;
			_sugar = sugar;
			_beer = beer;
		}

		public void Build()
		{
			Console.WriteLine($"Preparing drinks with some of water {_water}" +
				$"sugar {_sugar} and beer {_beer.Name}");
		}
	}
}

