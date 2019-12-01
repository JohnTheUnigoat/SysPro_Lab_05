using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_05
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        private Department department;

        public Department Department
        {
            get
            {
                if (department != null && department.IsRemoved())
                    department = null;

                return department;
            }
            set
            {
                department = value;
            }
        }

        public string DepartmentPhone
        {
            get
            {
                if (department == null)
                    return "";

                return Department.PhoneNumber;
            }
        }

        public string DepartmentAdress
        {
            get
            {
                if (department == null)
                    return "";

                return Department.Address;
            }
        }

        public Employee(string name, int age, decimal salary, Department department)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Department = department;
        }
    }
}
