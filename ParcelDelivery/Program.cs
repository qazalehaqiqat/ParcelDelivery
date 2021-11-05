using System;
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
            Console.WriteLine("{0,-25}{1,-15}{2,-10}{3,-10}{4,0}\n", "Sender", "Receipient", "Weight", "Value", "Status");

            var distribution = new Distribution();

            

            foreach (Parcel p in shipping.Parcels)
            {
                var status = "";
                var dep = distribution.GetTargetDepartments(p);
                foreach (var t in dep)
                {
                    status += status != "" ? "," + t.HandleParcel() : t.HandleParcel();
                }
                Console.WriteLine("{0,-25}{1,-15}{2,-10}{3,-10}{4,0}\n", p.Sender.Name, p.Receipient.Name, p.Weight, p.Value, status);
            }
            Console.ReadKey();
        }
    }
}