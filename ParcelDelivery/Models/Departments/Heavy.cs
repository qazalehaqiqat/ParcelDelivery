using ParcelDelivery.Interfaces;

namespace ParcelDelivery.Models.Departments
{
    public class Heavy : IDepartment
    {
        public string HandleParcel()
        {
            return "Parcel is being handled by heavy department";
        }
    }
}