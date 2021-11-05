using ParcelDelivery.Interfaces;

namespace ParcelDelivery.Models.Departments
{
    public class Insurance : IDepartment
    {
        public string HandleParcel()
        {
            return "Parcel should be signed by insurance department";
        }
    }
}