using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    class Cat : Pet
    {
        
        public Cat(string name,
                   Size size,
                   double weight,
                   Breed breed,
                   VaccineType isVaccinated,
                   Age age,
                   float price)
        {
            _type = PetType.Cat;
            _animalClass = AnimalClass.Mammal;
            _name = name;
            _size = size;
            _weight = weight;
            _breed = breed;
            _isVaccinated = isVaccinated;
            _age = age;
            _price = price;
        }

    }
}
