using System.Xml.Serialization;

namespace ParcelDelivery.Models.Entities
{
    [XmlInclude(typeof(Company))]
    public class Parcel
    {
        public Parcel()
        {
        }

        public Parcel(double value, double weight, User sender, User receipient)
        {
            Value = value;
            Weight = weight;
            Sender = sender;
            Receipient = receipient;
        }

        public double Value { get; set; }
        public double Weight { get; set; }
        public User Sender { get; set; }
        public User Receipient { get; set; }
    }
}