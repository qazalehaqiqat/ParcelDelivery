using System;
using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Entities;
using ParcelDelivery.Models.Departments;

namespace ParcelDelivery.Factories
{
    public class HeavyFactory : DepartmentFactory
    {
        public HeavyFactory()
        {
        }

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
