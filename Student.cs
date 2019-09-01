using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBrushUp
{
    public class Student
    {
        public string _name;
        public string _address;
        public int _semester;
        public Enum _enum;

        public Student(string name, string address, int semester, Enum @enum)
        {
            _name = name;
            _address = address;
            _semester = semester;
            _enum = @enum;
        }

        public string Name()
        {

        }


    }
}
