using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Departments;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery.Factories
{
    public class InsuranceFactory : DepartmentFactory
    {
        public override IDepartment CreateDepartment()
        {
            return new Insurance();
        }

        public override bool Validate(Parcel parcel)
        {
            if (parcel.Value > 1000) return true;
            return false;
        }
    }
}