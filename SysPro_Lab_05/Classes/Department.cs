using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_05
{
    public class Department : IComparable
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        private bool isRemoved;

        public Department(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;

            isRemoved = false;
        }

        public void MarkRemoved()
        {
            isRemoved = true;
        }

        public bool IsRemoved()
        {
            return isRemoved;
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Department).Name);
        }
    }
}
