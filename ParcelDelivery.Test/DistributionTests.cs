using ParcelDelivery.Models.Departments;
using ParcelDelivery.Models.Entities;
using Xunit;

namespace ParcelDelivery.Test
{
    public class DistributionTests
    {
        private readonly Distribution distribution = new();

        [Fact]
        public void Should_Return_Objects_Of_Heavy_And_Insurance_When_Parcel_Value_More_Than_1000_And_Weight_More_Than_10_Kg()
        {
            var sender = new User("Shell Company", new Address("Schiekade", 125, "1234", "Rotterdam"));

            var receipient = new User("Daniel", new Address("Rottumeroog", 38, "2134", "Hoofddorp"));

            var parcel = new Parcel(1900, 600, sender, receipient);

            var result = distribution.GetTargetDepartments(parcel);

            Assert.Contains(result, x => x.GetType() == typeof(Heavy));
            Assert.Contains(result, x => x.GetType() == typeof(Insurance));
        }
    }
}