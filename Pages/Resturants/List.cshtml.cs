using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }//having to use this as the data source
        public IEnumerable<Resturant> Resturants { get; set; }



        //using the app settings as data source
        public ListModel(IConfiguration config,IResturantData resturantData)
        {
            _config = config;
            this.resturantData = resturantData;
        }
        private readonly IConfiguration _config;
        private readonly IResturantData resturantData;

        public void OnGet()
        {
            //Value from App settings
            //Used it as as a data source
            Message = _config["Message"];
            Resturants = resturantData.GetAll();
           

        }
    }
}
