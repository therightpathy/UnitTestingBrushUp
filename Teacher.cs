using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBrushUp
{
    public class Teacher
    {
        public enum Gender
        {
            Male,
            Female
        }

        private string _name;
        private string _address;
        private double _salary;
        private Gender _gender;

        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                CheckAddress(value);
                _address = value;
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                CheckSalary(value);
                _salary = value;
            }
        }

        public Gender gender
        {
            get => _gender;
            set => _gender = value;
        }

        public Teacher(string name, string address, double salary, Gender gender)
        {
            CheckName(name);
            CheckAddress(address);
            CheckSalary(salary);
            Name = name;
            Address = address;
            Salary = salary;
            _gender = gender;
        }

        private static bool CheckName(string name)
        {
            if(name.Length <= 2)
            {
                throw new ArgumentException("Name must be more than two characters");
            }
            return true;
        }

        private static void CheckAddress(string address)
        {
            if(String.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address must be filled");
            }
        }

        private static void CheckSalary(double salary)
        {
            if(salary < 0)
            {
                throw new ArgumentOutOfRangeException("Salary must be positive");
            }
        }
    }
}
