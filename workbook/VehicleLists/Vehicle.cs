using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLists
{
    internal class Vehicle
    {
        private string _name;
        private string _description;

        public Vehicle()
        {
            _name = string.Empty;
            _description = string.Empty;
        }
        public Vehicle(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }

        // THIS PRINTS OUT TO CONSOLE INSTEAD OF RETURNING A STRING.
        public void Travel(double distance)
        {
            Console.WriteLine($"{_name} was used to travel {distance} meters");
        }


    }
}
