using PizzaStore.Client;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
    public class StarterTest
    {
        [Fact]
        public void Test_CreateOrder()
        {
            var user = new User();
            var store = new Store("storeOne");
            var sut = new Startup();



            var actual = sut.CreateOrder(user, store);

            Assert.NotNull(actual);
        }
    }
}