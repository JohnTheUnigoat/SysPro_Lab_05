using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_05
{
    public class Department
    {
        public string Name { get; set; }

        private string phoneNumber;
        public string PhoneNumber {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("A phone number should be exactly 10 digits long!");

                if (!value.All(symbol => char.IsDigit(symbol)))
                    throw new ArgumentException("A phone number can only contain digits!");

                phoneNumber = value;
            }
        }

        public string Address { get; set; }

        public Department(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
