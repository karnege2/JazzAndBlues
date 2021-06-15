using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace JazzAndBlues.CORE.Tests
{
    [TestClass]
    public class ShopsShould
    {
        [TestMethod]
        public void Init_Property_Once()
        {
            var sut = new Shop()
            {
                Address = new Address() { City = "London", StreetName = "Bush Street" },
                Cuisine = Cuisine.Generic,
                Id = 1,
                StoreName = "Callisto Restaurants"
            };

            var sut2 = new Shop()
            {
                Address = new Address() { City = "London", StreetName = "Bush Street" },
                Cuisine = Cuisine.Generic,
                Id = 1,
                StoreName = "Callisto Restaurants"
            };

            Assert.IsNotNull(sut);

            Assert.AreNotEqual(sut, sut2);

        }

        [TestMethod]
        public void Init_A_Record()
        {
            var sut = new Games("Gas-lighting Core", 1, "Sports");
            var sut2 = new Games("Gas-lighting Core", 1, "Sports");

            Assert.AreEqual(sut, sut2);
        }
        [TestMethod]
        public void Get_A_Record()
        {
            var sut = new Games("Gas-lighting Core", 1, "Sports");
            var sut2 = sut with {Id = 2};

            var list = new List<Games>() {sut, sut2};
            var id= list.First().Id;
            Assert.AreNotEqual(sut, sut2);
            CollectionAssert.Contains(list,sut);
            Assert.IsTrue(id>0);
        }
    }

}
