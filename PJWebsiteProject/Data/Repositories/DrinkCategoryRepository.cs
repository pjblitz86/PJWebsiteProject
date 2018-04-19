using PJWebsiteProject.Models.DrinkModels;
using System.Collections.Generic;

namespace PJWebsiteProject.Data.Repositories
{
	public class DrinkCategoryRepository : IDrinkCategoryRepository
	{
		private readonly ApplicationDbContext _applicationDbContext;

		public DrinkCategoryRepository(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}

		public IEnumerable<DrinkCategory> DrinkCategories => _applicationDbContext.DrinkCategories;
	}
}
