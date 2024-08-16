using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingIntoObjects
{
    internal class Student
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private double _grade;

        public Student(int id, string firstName, string lastName, double grade)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _grade = grade;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                _firstName = value;
            }
        }


        public double Grade
        {
            get { return _grade; }
        }


        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }
    }
}
