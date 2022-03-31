using System;
namespace The_Inventory.Models
{
	public class Location
	{

		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Address { get; set; } = string.Empty;

		public int Money { get; set; }

		public bool LocationActive { get; set; }

		public Location()
		{
		}
	}
}

