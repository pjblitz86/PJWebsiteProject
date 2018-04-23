﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PJWebsiteProject.Models.DrinkModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PJWebsiteProject.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderRepository _orderRepository;
		private readonly ShoppingCart _shoppingCart;

		public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
		{
			_orderRepository = orderRepository;
			_shoppingCart = shoppingCart;
		}

		[Authorize]
		public IActionResult Checkout()
		{
			return View();
		}

		[Authorize]
		[HttpPost]
		public IActionResult Checkout(Order order)
		{
			var items = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = items;

			if (_shoppingCart.ShoppingCartItems.Count == 0)
			{
				ModelState.AddModelError("", "Your cart is empty, add some drinks first");
			}

			if (ModelState.IsValid)
			{
				_orderRepository.CreateOrder(order);
				_shoppingCart.ClearCart();
				return RedirectToAction("CheckoutComplete");
			}

			return View(order);
		}

		[Authorize]
		public IActionResult CheckoutComplete()
		{
			ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
			return View();
		}
	}
}