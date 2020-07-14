using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class EditModel : PageModel
    {
        private readonly IResturantData resturantData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public Resturant  Resturant { get; set; }
        public IEnumerable<SelectListItem> Cusines { get; set; }


        public EditModel(IResturantData resturantData,IHtmlHelper htmlHelper)
        {
            this.resturantData = resturantData;
            this.htmlHelper =
                htmlHelper;
        }
        public IActionResult OnGet(int resturantId)
        {
            Cusines = htmlHelper.GetEnumSelectList<CuisineType>();
            Resturant = resturantData.getById(resturantId);
            if (Resturant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                resturantData.Update(Resturant);
                resturantData.Commit();
            }
            Cusines = htmlHelper.GetEnumSelectList<CuisineType>();
          


            return Page();
        }
    }
}