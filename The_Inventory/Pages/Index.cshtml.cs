﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message = "";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Chemical> allChemicals = new List<Chemical>();
        public List<Location> allLocation = new List<Location>();


        public void OnGet()
        {
            Message = Database.GetVersion();

            allChemicals = new Inventory().Chemicals;
            allLocation = new Inventory().Locations;

        }

    }
}
