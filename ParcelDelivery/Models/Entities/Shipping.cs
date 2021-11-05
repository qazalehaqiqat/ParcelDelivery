using System;
using System.Xml.Serialization;

namespace ParcelDelivery.Models.Entities
{
    [XmlRoot(ElementName = "Container")]
    public class Shipping
    {
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }

        [XmlArray("parcels")] public Parcel[] Parcels { get; set; }
    }
}