using System;
using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Entities;
using ParcelDelivery.Models.Departments;

namespace ParcelDelivery.Factories
{
    public class MailFactory : DepartmentFactory
    {
        public MailFactory()
        {
        }

        public override IDepartment CreateDepartment()
        {
            return new Mail();
        }

        public override bool Validate(Parcel parcel)
        {
            if (parcel.Weight <= 1) return true;
            return false;
        }
    }
}
