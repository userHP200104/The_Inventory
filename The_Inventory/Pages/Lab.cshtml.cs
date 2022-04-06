using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using The_Inventory.Models;
using The_Inventory.Services;

namespace The_Inventory.Pages
{
    public class LabModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public LabModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public string Message { get; set; } = string.Empty;

        public List<Chemical> allChemical = new List<Chemical>();
        public List<Reaction> allReactions = new List<Reaction>();
        public List<Location> allLocation = new List<Location>();


        public void OnGet(string message = "")
        {

            Message = message;


            allChemical = new Inventory().Chemicals;
            allReactions = new Inventory().Reactions;
            allLocation = new Inventory().Locations;

        }


        public IActionResult OnPostCraft(string name, string state, string catergory, int activeLocation)
        {

            Console.WriteLine(name);

            var rawChemical = Database.GetRawChemical(name);

            var chemicalOutOfStock = new HashSet<string>(); 

            bool hasReacted = false;

            Console.WriteLine($"This is the active location id {activeLocation}");

            
            foreach(var chemical in rawChemical)
            {
                if (Database.GetQuantity(chemical, activeLocation) != 0) 
                {
                    hasReacted = true;
                    Console.WriteLine($"{chemical} is In Stock");

                }
                else
                {
                    if (chemical != "")
                    { 
                        chemicalOutOfStock.Add(chemical);

                        hasReacted = false;

                        Console.WriteLine($"{chemical} is Out of Stock");
                    }
                }

            }

            if (hasReacted)
            {
                Database.CreateReaction(name, state, catergory, activeLocation);

                foreach (var chemical in rawChemical)
                {
                    if (chemical != "")
                    {
                        Database.DecreaseRawChemical(chemical, activeLocation);
                    }

                }

                return Redirect($"./Lab?message={name} has been crafted");
            }
            else
            {
                string outOfStock = "";

                foreach(var chemical in chemicalOutOfStock)
                {
                    outOfStock = outOfStock + ", " + chemical;
                }

                return Redirect($"./Lab?message=you need to stock up on {outOfStock}");
            }


                

        }

    }
}
