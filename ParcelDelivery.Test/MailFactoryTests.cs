using ParcelDelivery.Factories;
using ParcelDelivery.Models.Entities;
using Xunit;

namespace ParcelDelivery.Test
{
    public class MailFactoryTests
    {
        private readonly MailFactory mailFactory = new();

        [Fact]
        public void Should_Return_True_When_Parcels_Up_To_One_Kg()
        {
            var sender = new User("Shell Company", new Address("Schiekade", 125, "1234", "Rotterdam"));

            var receipient = new User("Daniel", new Address("Rottumeroog", 38, "2134", "Hoofddorp"));

            var parcel = new Parcel(2, 0.98, sender, receipient);

            var result = mailFactory.Validate(parcel);
            Assert.True(result);
        }
    }
}