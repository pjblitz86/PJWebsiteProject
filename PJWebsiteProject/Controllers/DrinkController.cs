using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models.DrinkModels;
using PJWebsiteProject.ViewModels;

namespace PJWebsiteProject.Controllers
{
	public class DrinkController : Controller
	{
		private readonly IDrinkCategoryRepository _drinkCategoryRepository;
		private readonly IDrinkRepository _drinkRepository;

		public DrinkController(IDrinkCategoryRepository drinkCategoryRepository, IDrinkRepository drinkRepository) // service dependency injection
		{
			_drinkCategoryRepository = drinkCategoryRepository;
			_drinkRepository = drinkRepository;
		}

		public ViewResult List()
		{
			ViewBag.Name = "DotNet,how?";
			var drinks = _drinkRepository.Drinks;
			DrinkListViewModel vm = new DrinkListViewModel
			{
				Drinks = _drinkRepository.Drinks,
				CurrentCategory = "DrinkCategory"
			};

			return View(vm);
		}
	}
}
