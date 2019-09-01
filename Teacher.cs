using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBrushUp
{
    class Teacher
    {
        public enum Gender
        {
            Male,
            Female
        }

        private string name;
        private string address;
        private double salary;

        public string Name
        {
            get => name;
            set
            {
                CheckName(value);
                name = value;
            }
        }

        public string Address { get => address; set => address = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
