using System.Collections.Generic;
using ParcelDelivery.Factories;
using ParcelDelivery.Interfaces;

namespace ParcelDelivery.Models.Entities
{
    public class Distribution
    {
        public List<IDepartment> GetTargetDepartments(Parcel parcel)
        {
            var deptFactories = new List<DepartmentFactory>();
            DepartmentFactory insuranceFactory = new InsuranceFactory();
            DepartmentFactory mailFactory = new MailFactory();
            DepartmentFactory heavyFactory = new HeavyFactory();
            DepartmentFactory regularFactory = new RegularFactory();

            deptFactories.Add(mailFactory);
            deptFactories.Add(insuranceFactory);
            deptFactories.Add(regularFactory);
            deptFactories.Add(heavyFactory);

            var dept = new List<IDepartment>();

            for (var i = 0; i < deptFactories.Count; i++)
                if (deptFactories[i].Validate(parcel))
                    dept.Add(deptFactories[i].CreateDepartment());

            return dept;
        }
    }
}