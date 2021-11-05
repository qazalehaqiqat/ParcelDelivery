using ParcelDelivery.Factories;
using ParcelDelivery.Models.Entities;
using Xunit;

namespace ParcelDelivery.Test
{
    public class HeavyFactoryTests
    {
        private readonly HeavyFactory heavyFactory = new();

        [Fact]
        public void Should_Return_True_When_Parcel_Is_More_Than_Ten_Kg()
        {
            var sender = new User("Shell Company", new Address("Schiekade", 125, "1234", "Rotterdam"));

            var receipient = new User("Daniel", new Address("Rottumeroog", 38, "2134", "Hoofddorp"));

            var parcel = new Parcel(700, 100, sender, receipient);

            var result = heavyFactory.Validate(parcel);

            Assert.True(result);
        }
    }
}