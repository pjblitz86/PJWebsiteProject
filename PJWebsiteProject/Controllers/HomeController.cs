﻿using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models;
using PJWebsiteProject.Models.DrinkModels;
using PJWebsiteProject.ViewModels;
using System.Diagnostics;

namespace PJWebsiteProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDrinkRepository _drinkRepository;

		public HomeController(IDrinkRepository drinkRepository)
		{
			_drinkRepository = drinkRepository;
		}

		public ViewResult Index()
		{
			var homeViewModel = new HomeViewModel
			{
				PreferedDrinks = _drinkRepository.PreferedDrinks
			};
			return View(homeViewModel);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
