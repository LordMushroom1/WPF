using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public abstract class Pet
    {

        protected string _name;
        protected Size _size;
        protected double _weight;
        protected Breed _breed;
        protected VaccineType _isVaccinated;
        protected Age _age;
        protected PetType _type;
        protected AnimalClass _animalClass;
        protected float _price;

        public string Name   
        {
            get { return _name; }   
        }
        public Size Size
        {
            get { return _size; }
        }
        public double Weight
        {
            get { return _weight; }
        }
        public Breed Breed
        {
            get { return _breed; }
        }
        public VaccineType IsVaccinated
        {
            get { return _isVaccinated; }
        }
        public Age Age
        {
            get { return _age; }
        }
        public PetType Type
        {
            get { return _type; }
        }
        public AnimalClass AnimalClass
        {
            get { return _animalClass; }
        }

        public float Price
        {
            get { return _price; }
        }
    }
}
