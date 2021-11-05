using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Departments;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery.Factories
{
    public class HeavyFactory : DepartmentFactory
    {
        public override IDepartment CreateDepartment()
        {
            return new Heavy();
        }

        public override bool Validate(Parcel parcel)
        {
            if (parcel.Weight > 10) return true;
            return false;
        }
    }
}