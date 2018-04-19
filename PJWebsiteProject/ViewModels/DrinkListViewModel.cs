using PJWebsiteProject.Models.DrinkModels;
using System.Collections.Generic;

namespace PJWebsiteProject.ViewModels
{
	public class DrinkListViewModel
	{
		public IEnumerable<Drink> Drinks { get; set; }
		public string CurrentCategory { get; set; }
	}
}
