﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class DetailModel : PageModel
    {
        private readonly IResturantData resturantData;

        public Resturant Resturant { get; set; }
    
        public IActionResult OnGet(int ResturantId)
        {
            Resturant = resturantData.getById(ResturantId);
            if (Resturant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public DetailModel(IResturantData resturantData)
        {
            this.resturantData = resturantData;
        }
    }
}