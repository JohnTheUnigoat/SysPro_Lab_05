using System;
using System.Runtime.Serialization;

namespace SysPro_Lab_05
{
    [DataContract(IsReference = true)]
    public class Department : IComparable
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
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
