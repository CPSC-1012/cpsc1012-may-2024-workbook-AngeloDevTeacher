using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    /// <summary>
    /// An appointment - described by a name and date.
    /// </summary>
    internal class Appointment
    {
        private string _appointmentName;
        private DateTime _appointmentDate;

        public string AppointmentName
        {
            get
            {
                return _appointmentName;
            }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    _appointmentName = value;
                }
                else
                {
                    throw new Exception("The appointment name cannot be empty.");
                }
            }
        }

        public DateTime AppointmentDate
        {
            get
            {
                return _appointmentDate;
            }
            set
            {
                if(value.ToString() == string.Empty || !DateTime.TryParse(value.ToString(), out _appointmentDate))
                {
                    throw new Exception("Date could not be set.");
                }
                
            }
        }
        /// <summary>
        /// Create a new <c>appointment</c> using <cref>appointmentName</cref> and <cref>appointmentDate</cref>.
        /// </summary>
        /// <param name="name">The name of the appointment.</param>
        /// <param name="date">The date of the appointment.</param>
        public Appointment(string name, DateTime date) 
        {
            _appointmentName = name;
            _appointmentDate = date;
        }
        public override string ToString()
        {
            return $"{_appointmentName}, {_appointmentDate.ToShortDateString()}";
        }
    }


}
