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
    public class WarehouseModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message = "";

        public WarehouseModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Location> allLocation = new List<Location>();
        //public List<Location> activeLocation = new List<Location>();

        public void OnGet()
        {
            Message = Services.Database.GetVersion();

            allLocation = new Inventory().Locations;
            //activeLocation = new Inventory().ActiveLocation;

        }

        public IActionResult OnPostSwitch(string name, string address, string money, bool locationActive)
        {

            //Console.WriteLine(name, address, money, locationActive);

            Database.deactivateAllLocations();
            Database.switchLocation(name);

            return Redirect($"./warehouse");
        }

    }

}
