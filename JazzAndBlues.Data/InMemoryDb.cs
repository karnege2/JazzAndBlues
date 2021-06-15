using System.Collections.Generic;
using System.Linq;
using JazzAndBlues.CORE;

namespace JazzAndBlues.Data
{
    public class InMemoryDb : IShopService
    {
        private readonly List<Shop> list = new()
        {
            new Shop()
            {
                Address = new Address() {City = "London", StreetName = "Bush Street"},
                Cuisine = Cuisine.Generic,
                Id = 1,
                StoreName = "Callisto Restaurants"
            },
            new Shop()
            {
                Address = new Address() {City = "Nottingham", StreetName = "Redford RD"},
                Cuisine = Cuisine.Moroccan,
                Id = 2,
                StoreName = "Marrakesh Restaurants"
            },
            new Shop()
            {
                Address = new Address() {City = "Birmingham", StreetName = "Baker Street"},
                Cuisine = Cuisine.Italian,
                Id = 3,
                StoreName = "Mariano Restaurants"
            }
        };

        public IEnumerable<Shop> GetAll()
        {
            return from s in list orderby s.StoreName select s;
        }
    }
}