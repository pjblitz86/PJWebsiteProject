using System.Collections.Generic;

namespace PJWebsiteProject.Models.DrinkModels
{
	public interface IDrinkCategoryRepository
	{
		IEnumerable<DrinkCategory> DrinkCategories { get; }
	}
}
