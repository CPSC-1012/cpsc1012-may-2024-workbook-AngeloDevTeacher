using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetExamples
{
    internal class Pet
    {
        protected string _petName;
        protected string _petBreed;
        protected int _petAge;
        protected string _petDescription;

        internal string Name
        {
            get
            {
                return _petName;
            }
        }

        public Pet()
        {
            _petName = string.Empty;
            _petBreed = string.Empty;
            _petAge = 0;
            _petDescription = string.Empty;
        }

        public Pet(string name, string breed, int age, string description)
        {
            _petName = name;
            _petBreed = breed;
            _petAge = age;
            _petDescription = description;
        }
    }
}
