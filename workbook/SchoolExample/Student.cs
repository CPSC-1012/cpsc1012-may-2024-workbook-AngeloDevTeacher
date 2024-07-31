using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    /// <summary>
    /// A student with a name and ID.
    /// </summary>
    internal class Student
    {
        // These are member variables - they belong to the class and each instance can have different values for each of them.

        // Name them using an underscore if they are private.
        private string _firstName;
        private string _lastName;
        private int _id;

        // This is the DEFAULT constructor, and it can override C#'s 
        // setting to make your own defaults.
        /// <summary>
        /// Sets the first name to "first" and last name to "last"
        /// </summary>
        public Student()
        {
            _firstName = "first";
            _lastName = "last";
            _id = 0;
        }

        // This is the constructor - which triggers when we say something is a "new" thing. In this case, a new student. Finally, this is a GREEDY constructor that sets all the variables.
        /// <summary>
        /// Sets the student with a first name, last name, and id.
        /// </summary>
        /// <seealso cref="https://nait.ca">"Link"</seealso>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>

        public Student(string firstName, string lastName, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns>First name as a string.</returns>
        public string GetFirstName()
        {
            return _firstName;
        }

        /// <summary>
        /// Sets the first anme, if the value is not null or empty. Will trim the passed in value.
        /// </summary>
        /// <param name="firstName"></param>
        public void SetFirstName(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                _firstName = firstName.Trim();
            }
            
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetLastName(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                _lastName = lastName.Trim();
            }
        }

        public void SetId(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <returns>Full name as a string.</returns>
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
