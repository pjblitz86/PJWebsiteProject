using Microsoft.EntityFrameworkCore;
using PJWebsiteProject.Models.DrinkModels;
using System.Collections.Generic;
using System.Linq;

namespace PJWebsiteProject.Data.Repositories
{
	public class DrinkRepository : IDrinkRepository
	{
		private readonly ApplicationDbContext _applicationDbContext;
		public DrinkRepository(ApplicationDbContext applicationDbContext) // service injection
		{
			_applicationDbContext = applicationDbContext;
		}

		public IEnumerable<Drink> Drinks => _applicationDbContext.Drinks.Include(c => c.DrinkCategory);

		public IEnumerable<Drink> PreferedDrinks => _applicationDbContext.Drinks.Where(p => p.IsPreferedDrink).Include(c => c.DrinkCategory);

		public Drink GetDrinkById(int drinkId) => _applicationDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
	}
}
