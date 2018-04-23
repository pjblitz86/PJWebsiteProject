using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models.DrinkModels;

namespace PJWebsiteProject.Components
{
	public class CategoryMenu : ViewComponent
	{
		private readonly IDrinkCategoryRepository _drinkCategoryRepository;

		public CategoryMenu(IDrinkCategoryRepository drinkCategoryRepository)
		{
			_drinkCategoryRepository = drinkCategoryRepository;
		}

		public IViewComponentResult Invoke()
		{
			var categories = _drinkCategoryRepository.DrinkCategories.OrderBy(p => p.CategoryName);
			return View(categories);
		}
	}
}
