using System;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace JazzAndBlues.Data
{
  public class Database
    {
        private readonly IShopService _shopService;

        public Database(IShopService shopService)
        {
            _shopService = shopService;
        }


    }
}
