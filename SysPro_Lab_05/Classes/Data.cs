using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SysPro_Lab_05
{
    [DataContract]
    public class Data
    {
        [DataMember]
        public List<Department> Departments { get; set; }

        [DataMember]
        public List<Employee> Employees { get; set; }

        public List<string> DepartmentFilterOptions
        {
            get
            {
                var res = new List<string>(Departments.Count + 1);

                res.Add("All departments");

                foreach(var item in Departments)
                {
                    res.Add(item.Name);
                }

                return res;
            }
        }

        public Data()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }
    }
}
