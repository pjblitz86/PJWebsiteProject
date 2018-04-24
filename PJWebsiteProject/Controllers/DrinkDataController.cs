using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models.DrinkModels;
using PJWebsiteProject.ViewModels;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PJWebsiteProject.Controllers
{
	[Route("api/[controller]")]
	public class DrinkDataController : Controller
	{
		private readonly IDrinkRepository _drinkRepository;

		public DrinkDataController(IDrinkRepository drinkRepository)
		{
			_drinkRepository = drinkRepository;
		}

		[HttpGet]
		public IEnumerable<DrinkViewModel> LoadMoreDrinks()
		{
			IEnumerable<Drink> dbDrinks = null;

			dbDrinks = _drinkRepository.Drinks.OrderBy(p => p.DrinkId).Take(10);

			List<DrinkViewModel> drinks = new List<DrinkViewModel>();

			foreach (var dbDrink in dbDrinks)
			{
				drinks.Add(MapDbDrinkToDrinkViewModel(dbDrink));
			}
			return drinks;
		}

		private DrinkViewModel MapDbDrinkToDrinkViewModel(Drink dbDrink) => new DrinkViewModel()
		{
			DrinkId = dbDrink.DrinkId,
			Name = dbDrink.Name,
			Price = dbDrink.Price,
			ShortDescription = dbDrink.ShortDescription,
			ImageThumbnailUrl = dbDrink.ImageThumbnailUrl
		};

	}
}
