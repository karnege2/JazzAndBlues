using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using JazzAndBlues.CORE;

namespace JazzAndBlues.Data
{
    public class InMemoryDb : IShopService
    {
        private readonly List<Shop> _list = new()
        {
            new Shop
            {
                Address = new Address {City = "London", StreetName = "Bush Street"},
                Cuisine = Cuisine.Generic,
                Id = 1,
                StoreName = "Callisto Restaurants"
            },
            new Shop
            {
                Address = new Address {City = "Nottingham", StreetName = "Redford RD"},
                Cuisine = Cuisine.Moroccan,
                Id = 2,
                StoreName = "Marrakesh Restaurants"
            },
            new Shop
            {
                Address = new Address {City = "Birmingham", StreetName = "Baker Street"},
                Cuisine = Cuisine.Italian,
                Id = 3,
                StoreName = "Mariano Restaurants"
            }
        };

        public IEnumerable<Shop> GetAll() => from s in _list orderby s.StoreName select s;

        public IEnumerable<Shop> GetShop(string name) => from s in _list
            where string.IsNullOrWhiteSpace(name) || s.StoreName.StartsWith(name)
            orderby s.StoreName
            select s;

        public Shop GetShopById(int shopId) => _list.FirstOrDefault(x => x.Id == shopId);
    }
}