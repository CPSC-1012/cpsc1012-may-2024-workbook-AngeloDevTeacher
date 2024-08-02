using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetExamples
{
    internal class Cat : Pet, IWalkable
    {

        private CatBreeds _breed;
        internal string BreedName
        {
            get
            {
                return _breed.ToString();
            }
            set
            {
                _breed = (CatBreeds)int.Parse(value);
            }
        }

        private int _walks = 0;
        internal int WalkCount
        {
            get
            {
                return _walks;
            }
        }


        public Cat()
        {
            _petName = string.Empty;
            _petBreed = string.Empty;
            _petAge = 0;
            _petDescription = string.Empty;
        }


        public Cat(string name, string breed, int age, string description)
        {
            _petName = name;
            _petBreed = breed;
            _petAge = age;
            _petDescription = description;
        }

        public void Walk()
        {
            Console.WriteLine($"{ _petName} has gone on a walk.");
            _walks++;
        }
    }


    internal enum CatBreeds
    {
        NONE,
        NORWEGIAN_FOREST_CAT,
        TIGER,
        BLACK_FOOTED_CAT,
        RUSSIAN_BLUE,
        SCOTTISH_FOLDER
    }
}
