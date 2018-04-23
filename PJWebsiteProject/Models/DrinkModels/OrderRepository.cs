using PJWebsiteProject.Data;
using System;

namespace PJWebsiteProject.Models.DrinkModels
{
	public class OrderRepository : IOrderRepository
	{
		private readonly ApplicationDbContext _applicationDbContext;
		private readonly ShoppingCart _shoppingCart;

		public OrderRepository(ApplicationDbContext applicationDbContext, ShoppingCart shoppingCart)
		{
			_applicationDbContext = applicationDbContext;
			_shoppingCart = shoppingCart;
		}

		public void CreateOrder(Order order)
		{
			order.OrderPlaced = DateTime.Now;
			_applicationDbContext.Orders.Add(order);

			var shoppingCartItems = _shoppingCart.ShoppingCartItems;

			foreach (var item in shoppingCartItems)
			{
				var orderDetail = new OrderDetail()
				{
					Amount = item.Amount,
					DrinkId = item.Drink.DrinkId,
					OrderId = order.OrderId,
					Price = item.Drink.Price
				};

				_applicationDbContext.OrderDetails.Add(orderDetail);
			}

			_applicationDbContext.SaveChanges();
		}
	}
}
