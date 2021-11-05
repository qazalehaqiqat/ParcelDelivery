using System.Xml;
using System.Xml.Serialization;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Shipping));
            var shipping =
                (Shipping)serializer.Deserialize(new XmlTextReader(@"../../../Assets/Container_68465468.xml"));
        }
    }
}