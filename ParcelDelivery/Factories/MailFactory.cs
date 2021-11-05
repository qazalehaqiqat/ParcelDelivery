using ParcelDelivery.Interfaces;
using ParcelDelivery.Models.Departments;
using ParcelDelivery.Models.Entities;

namespace ParcelDelivery.Factories
{
    public class MailFactory : DepartmentFactory
    {
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