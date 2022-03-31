using System;
namespace The_Inventory.Models
{
	public class Chemical
	{

        public int Id { get; set; }

        public int LocationId { get; set; }

        public string Name { get; set; } = string.Empty;

		public string Category { get; set; } = string.Empty;

		public string Image { get; set; } = string.Empty;

		public int Cost{ get; set; }

		public string State { get; set; } = string.Empty;

		private int quantity { get; set; }

        public int Quantity

        {
            get
            {
                // Functionallity
                return quantity;
            }

            set
            {
                // Functionallity
                if (value > 0)
                    quantity = value;
                else
                    quantity = 0;

            }
        }


        public Chemical(int newQuantity)
		{
            quantity = newQuantity;

        }
	}
}

