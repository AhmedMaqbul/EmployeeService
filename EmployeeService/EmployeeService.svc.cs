using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    //public class EmployeeService : IEmployeeService
    //{
    //    public string GetData(int value)
    //    {
    //        return string.Format("You entered: {0}", value);
    //    }

    //    public CompositeType GetDataUsingDataContract(CompositeType composite)
    //    {
    //        if (composite == null)
    //        {
    //            throw new ArgumentNullException("composite");
    //        }
    //        if (composite.BoolValue)
    //        {
    //            composite.StringValue += "Suffix";
    //        }
    //        return composite;
    //    }
    //}

    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployeeData(int id)
        {
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Rohit";
            employee1.IsAvailable = true;

            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Virat";
            employee2.IsAvailable = true;

            Employee employee3 = new Employee();
            employee3.ID = 2;
            employee3.Name = "Chahal";
            employee3.IsAvailable = false;

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            Employee resultEmployee = employees.FirstOrDefault(e => e.ID == id);
            return resultEmployee;
        }
    }
}
