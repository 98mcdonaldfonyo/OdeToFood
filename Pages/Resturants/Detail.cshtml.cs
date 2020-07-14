using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;

namespace OdeToFood.Pages.Resturants
{
    public class DetailModel : PageModel
    {
        public Resturant Resturant { get; set; }
    
        public void OnGet(int ResturantId)
        {
            Resturant = new Resturant();
            Resturant.Id = ResturantId;
        }
    }
}