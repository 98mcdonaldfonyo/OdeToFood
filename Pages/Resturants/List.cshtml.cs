using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace OdeToFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }//having to use this as the data source



        //using the app settings as data source
        public ListModel(IConfiguration config)
        {
            _config = config;
       
        }
        private readonly IConfiguration _config;
        public void OnGet()
        {
            //Value from App settings
            //Used it as as a data source
            Message = _config["Message"];
           

        }
    }
}
