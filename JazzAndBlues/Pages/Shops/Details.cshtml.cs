using JazzAndBlues.CORE;
using JazzAndBlues.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JazzAndBlues.Pages.Shops
{
    public class DetailsModel : PageModel
    {
        private readonly IShopService _shopService;
        public Shop Shop { get; set; }

        public DetailsModel(IShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult OnGet(int id)
        {

            Shop = _shopService.GetShopById(id);
            if (Shop == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();

        }
    }
}
