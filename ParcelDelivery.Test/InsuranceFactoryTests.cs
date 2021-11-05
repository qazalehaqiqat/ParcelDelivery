using ParcelDelivery.Factories;
using ParcelDelivery.Models.Entities;
using Xunit;

namespace ParcelDelivery.Test
{
    public class InsuranceFactoryTests
    {
        private readonly InsuranceFactory insuranceFactory = new();

        [Fact]
        public void Should_Return_True_When_Parcel_Value_Is_More_Than_One_Thousand()
        {
            var sender = new User("Shell Company", new Address("Schiekade", 125, "1234", "Rotterdam"));

            var receipient = new User("Daniel", new Address("Rottumeroog", 38, "2134", "Hoofddorp"));

            var parcel = new Parcel(1001, 100, sender, receipient);

            var result = insuranceFactory.Validate(parcel);

            Assert.True(result);
        }
    }
}