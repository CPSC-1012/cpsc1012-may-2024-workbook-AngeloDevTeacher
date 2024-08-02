using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetExamples
{
    internal class Bird : Pet
    {
        public Bird()
        {
            _petName = string.Empty;
            _petBreed = string.Empty;
            _petAge = 0;
            _petDescription = string.Empty;
        }

        public Bird(string name, string breed, int age, string description)
        {
            _petName = name;
            _petBreed = breed;
            _petAge = age;
            _petDescription = description;
        }
    }
}
