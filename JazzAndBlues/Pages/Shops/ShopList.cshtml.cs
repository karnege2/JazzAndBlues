using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JazzAndBlues.CORE;
using JazzAndBlues.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace JazzAndBlues.Pages.Shops
{
    public class ShopListModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IShopService _shopService;

        public string Message { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
        public ShopListModel(IConfiguration configuration, IShopService shopService)
        {
            _configuration = configuration;
            _shopService = shopService;
        }
        public void OnGet()
        {
            Message = _configuration["Message"];
            Shops = _shopService.GetShop(Search?.ToUpper());
        }
    }
}
