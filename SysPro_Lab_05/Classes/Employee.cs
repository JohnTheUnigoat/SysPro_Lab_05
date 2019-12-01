using System.Runtime.Serialization;

namespace SysPro_Lab_05
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public decimal Salary { get; set; }

        [DataMember]
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
