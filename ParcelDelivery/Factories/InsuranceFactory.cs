using System;
using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Entities;
using ParcelDelivery.Models.Departments;

namespace ParcelDelivery.Factories
{
    public class InsuranceFactory : DepartmentFactory
    {
        public InsuranceFactory()
        {
        }

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
