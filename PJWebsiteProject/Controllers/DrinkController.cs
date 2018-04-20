using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models.DrinkModels;
using PJWebsiteProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public ViewResult List(string category)
		{
			string _category = category;
			IEnumerable<Drink> drinks;

			string currentCategory = string.Empty;

			if (string.IsNullOrEmpty(category))
			{
				drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
				currentCategory = "All drinks";
			}
			else
			{
				if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
				{
					drinks = _drinkRepository.Drinks.Where(p => p.DrinkCategory.CategoryName.Equals("Alcoholic"))
						.OrderBy(p => p.Name);
				}
				else
				{
					drinks = _drinkRepository.Drinks.Where(p => p.DrinkCategory.CategoryName.Equals("Non-alcoholic"))
						.OrderBy(p => p.Name);


				}
				currentCategory = _category;
			}
			return View(new DrinkListViewModel
			{
				Drinks = drinks,
				CurrentCategory = currentCategory
			});
		}
	}
}
