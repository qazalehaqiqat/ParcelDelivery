using ParcelDelivery.Factories;
using ParcelDelivery.Models.Entities;
using Xunit;

namespace ParcelDelivery.Test
{
    public class RegularFactoryTests
    {
        private readonly RegularFactory regularFactory = new();

        [Fact]
        public void Should_Return_True_When_Parcel_Is_Between_one_To_Ten_Kg()
        {
            var sender = new User("Shell Company", new Address("Schiekade", 125, "1234", "Rotterdam"));

            var receipient = new User("Daniel", new Address("Rottumeroog", 38, "2134", "Hoofddorp"));

            var parcel = new Parcel(700, 5, sender, receipient);

            var result = regularFactory.Validate(parcel);

            Assert.True(result);
        }
    }
}