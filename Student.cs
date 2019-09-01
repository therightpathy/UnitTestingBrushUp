using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBrushUp
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;
        private Gender _gender;

        public string Name
        {
            get => _name;
            set
            {
                CheckName(value;)
                _name = value;
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                CheckAddress(value;)
                _name = value;
            }
        public int Semester
        {
            get => _semester;
            set
            {
                CheckSemester(value;)
                _semester = value;
            }
        }
        public Gender Gender { get => _gender; set => _gender = value; }

        public Student(string name, string address, int semester, Gender gender)
        {
            CheckName(Name);
            CheckAddress(Address);
            CheckSemester(Semester);
            Name = name;
            Address = address;
            Semester = semester;
        }

        private static bool CheckName(string name)
        {
            if (name.Length < 2)
            {
                throw new ArgumentException("Name must be more than two characters");
            }
            return true;
        }

        private static void CheckAddress(string address)
        {
            if(string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address must be filled");
            }
        }

        private static void CheckSemester(int semester)
        {
            if(semester < 1)
            {
                throw new ArgumentException("Semester must be between 1-8");
            }
            if (semester > 8)
            {
                throw new ArgumentException("Semester must be between 1-8");
            }
        }

        public override string ToString()
        {
            return string.Format("Student({0}, {1}, {2})", Name, Address, Semester);
        }
    }
}
