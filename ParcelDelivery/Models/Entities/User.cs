namespace ParcelDelivery.Models.Entities
{
    public class User
    {
        public User()
        {
        }

        public User(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public Address Address { get; set; }
    }
}