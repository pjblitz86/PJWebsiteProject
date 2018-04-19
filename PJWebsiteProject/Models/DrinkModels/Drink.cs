namespace PJWebsiteProject.Models.DrinkModels
{
	public class Drink
	{
		public int DrinkId { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public string ImageThumbnailUrl { get; set; }
		public bool IsPreferedDrink { get; set; }
		public bool InStock { get; set; }
		public int CategoryId { get; set; }
		public virtual DrinkCategory DrinkCategory { get; set; }
	}
}
