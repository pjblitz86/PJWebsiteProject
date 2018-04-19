using System.Collections.Generic;

namespace PJWebsiteProject.Models.DrinkModels.MockData
{
	public class MockDrinkCategoryRepository : IDrinkCategoryRepository
	{
		public IEnumerable<DrinkCategory> DrinkCategories
		{
			get
			{
				return new List<DrinkCategory>
				{
					new DrinkCategory { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
					new DrinkCategory { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
				};
			}
		}
	}
}
