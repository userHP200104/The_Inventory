using System;
using System.Collections.Generic;
using The_Inventory.Services;

namespace The_Inventory.Models
{
	public class Inventory
	{

		// Chemicals variable called form our frontend
		public List<Reaction> Reactions = new List<Reaction>();
		public List<Chemical> Chemicals = new List<Chemical>();
		public List<Location> Locations = new List<Location>();
		public List<Location> ActiveLocation = new List<Location>();

		// contructor to fetch our db

		public Inventory()
		{

			Reactions = Database.GetAllReactions();
			Chemicals = Database.GetAllChemicals();
			Locations = Database.getAllLocations();
			ActiveLocation = Database.getActiveLocation();
		}

	}
}

