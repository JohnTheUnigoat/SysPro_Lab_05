using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Data()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }
    }
}
