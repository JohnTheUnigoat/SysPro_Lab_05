using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_05
{
    public class Data
    {
        public List<Department> Departments { get; set; }

        public List<Employee> Employees { get; set; }

        public Data()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }
    }
}
