using ParcelDelivery.Interfaces;

namespace ParcelDelivery.Models.Departments
{
    public class Mail : IDepartment
    {
        public string HandleParcel()
        {
            return "Parcel is being handled by mail department";
        }
    }
}