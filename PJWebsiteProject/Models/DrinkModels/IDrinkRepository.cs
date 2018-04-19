using System.Collections.Generic;

namespace PJWebsiteProject.Models.DrinkModels
{
	public interface IDrinkRepository
	{
		IEnumerable<Drink> Drinks { get; }
		IEnumerable<Drink> PreferedDrinks { get; }

		Drink GetDrinkById(int drinkId);
	}
}
