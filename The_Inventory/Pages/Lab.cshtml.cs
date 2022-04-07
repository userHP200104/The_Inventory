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
        public string Danger{ get; set; } = string.Empty;
        public string Warning { get; set; } = string.Empty;

        public List<Chemical> allChemical = new List<Chemical>();
        public List<Reaction> allReactions = new List<Reaction>();
        //public List<Reaction> allReactionsQuantity = new List<Reaction>();
        public List<Location> allLocation = new List<Location>();


        public void OnGet(string message = "", string danger = "", string warning = "")
        {

            Message = message;
            Danger = danger;
            Warning = warning;


            allChemical = new Inventory().Chemicals;
            allReactions = new Inventory().Reactions;
            //allReactionsQuantity = new Inventory().Reactions;
            allLocation = new Inventory().Locations;

        }


        public IActionResult OnPostReact(string name, string state, string catergory, int activeLocation, string access)
        {

            if (Database.CheckReactAccess(name, access))
            {


                Console.WriteLine(name);

                var rawChemical = Database.GetRawChemical(name);

                var chemicalOutOfStock = new HashSet<string>();

                var hasReacted = 0;

                Console.WriteLine($"This is the active location id {activeLocation}");


                foreach (var chemical in rawChemical)
                {
                    if (Database.GetQuantity(chemical, activeLocation) != 0)
                    {
                        hasReacted = hasReacted;
                        Console.WriteLine($"{chemical} is In Stock");

                    }
                    else
                    {
                        if (chemical != "")
                        {
                            chemicalOutOfStock.Add(chemical);

                            hasReacted++;

                            Console.WriteLine($"{chemical} is Out of Stock");
                        }
                    }

                }

                Console.WriteLine($"hasReacted = {hasReacted}");


                if (hasReacted == 0)
                {
                    Database.CreateReaction(name, state, catergory, activeLocation);
                    Database.Pay(name, activeLocation);

                    foreach (var chemical in rawChemical)
                    {
                        if (chemical != "")
                        {
                            Database.DecreaseRawChemical(chemical, activeLocation);
                        }

                    }

                    return Redirect($"./Lab?message={name} has been created");
                }
                else
                {
                    string outOfStock = "";

                    foreach (var chemical in chemicalOutOfStock)
                    {
                        outOfStock = outOfStock + ", " + chemical;
                    }

                    return Redirect($"./Lab?warning=you need to stock up on {outOfStock}");
                }

            }
            else
            {
                return Redirect($"./Lab?danger=you don't have access to this reaction");
            }


                

        }

        public IActionResult OnPostBuy(string name, int locationId, int cost, int money, int newQuantity, string access)
        {
            if (newQuantity * cost <= money)
            {

                if(Database.CheckBuyAccess(name, access))
                {
                    Database.chemicalIncrease(name, locationId, newQuantity);
                    Database.moneyDecrease(name, locationId, cost, money, newQuantity);

                    return Redirect($"./Lab?message=you have bought {newQuantity} {name}");

                }
                else
                {
                    return Redirect($"./Lab?danger=you don't have acccess to buy chemicals");
                }
            }
            else
            {

                    return Redirect($"./Lab?warning=you don't have enough money");
            }

        }

    }
}
