using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery.Factories
{
    public abstract class DepartmentFactory
    {
        public abstract IDepartment CreateDepartment();

        public abstract bool Validate(Parcel parcel);
    }
}