using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Departments;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery.Factories
{
    public class RegularFactory : DepartmentFactory
    {
        public override IDepartment CreateDepartment()
        {
            return new Regular();
        }

        public override bool Validate(Parcel parcel)
        {
            if (1 < parcel.Weight && parcel.Weight <= 10) return true;
            return false;
        }
    }
}