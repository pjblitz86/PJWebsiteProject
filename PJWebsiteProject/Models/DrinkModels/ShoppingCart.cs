using System.Collections.Generic;

namespace PJWebsiteProject.Models.DrinkModels
{
	public class ShoppingCart
	{
		public string ShoppingCartId { get; set; }
		public List<ShoppingCartItem> ShoppingCartItems { get; set; }
	}
}
