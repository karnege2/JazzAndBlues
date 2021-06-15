using System.Collections.Generic;
using JazzAndBlues.CORE;

namespace JazzAndBlues.Data
{
    public interface IShopService
    {
        IEnumerable<Shop> GetAll();
    }
}