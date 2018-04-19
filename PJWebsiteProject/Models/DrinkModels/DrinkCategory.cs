using System.Collections.Generic;

namespace PJWebsiteProject.Models.DrinkModels
{
	public class DrinkCategory
	{
		public int DrinkCategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public List<Drink> Drinks { get; set; }
	}
}
