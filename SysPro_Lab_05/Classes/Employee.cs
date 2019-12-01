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

        public Department Department { get; set; }

        public string DepartmentPhone
        {
            get
            {
                return Department.PhoneNumber;
            }
        }

        public string DepartmentAdress
        {
            get
            {
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
