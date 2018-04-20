using PJWebsiteProject.Models.DrinkModels;
using System.Collections.Generic;

namespace PJWebsiteProject.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Drink> PreferedDrinks { get; set; }
	}
}
