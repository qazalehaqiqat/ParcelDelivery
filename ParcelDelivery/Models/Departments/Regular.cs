using ParcelDelivery.Interfaces;

namespace ParcelDelivery.Models.Departments
{
    public class Regular : IDepartment
    {
        public string HandleParcel()
        {
            return "Parcel is being handled by regular department";
        }
    }
}