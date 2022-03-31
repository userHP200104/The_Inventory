using System;
using System.Collections.Generic;

namespace The_Inventory.Models
{

	public class Reaction
	{

		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string State { get; set; } = string.Empty;

		public string Category { get; set; } = string.Empty;

		public string Image { get; set; } = string.Empty;

		public List<string> RawChemical { get; set; }
		public List<string> RawChemicalQuantity { get; set; }

		public Reaction()
		{
		}

	}
}

