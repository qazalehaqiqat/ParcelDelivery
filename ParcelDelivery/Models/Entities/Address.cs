namespace ParcelDelivery.Models.Entities
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string street, int houseNumber, string postalCode, string city)
        {
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
            City = city;
        }

        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}