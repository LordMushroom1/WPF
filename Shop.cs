using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WPF
{
    class Shop
    {
        private Pet[] _pets;
        private Stuff[] _stuff;

        public Pet[] Pets
        {
            get { return _pets; }
        }
        public Stuff[] Stuff
        {
            get { return _stuff; }
        }

        private void CreatePets()
        {
            Random random = new Random();
            string[] names = new string[1000];

            for (int i = 0; i < 1000; i++)
            {
                names[i] = "Name " + i;
            }
            
            Array sizes = Enum.GetValues(typeof(Size));
            Array ages = Enum.GetValues(typeof(Age));
            Array vaccines = Enum.GetValues(typeof(VaccineType));
            
            for (int i = 0; i < 1000; i++)
            {
                int randomIdx = random.Next(0, names.Length);
                string name = names[randomIdx];
                Size size = (Size)sizes.GetValue(random.Next(sizes.Length));
                Age age = (Age)ages.GetValue(random.Next(ages.Length));
                VaccineType vaccine = (VaccineType)ages.GetValue(random.Next(vaccines.Length));
                Array breeds;
                Breed breed;
                switch (randomIdx % 6)
                {
                    case 0:
                        breeds = Enum.GetValues(typeof(CatBreed));
                        CatBreed catBreed = (CatBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(catBreed, catBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Cat cat = new Cat(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 8000));
                        _pets[i] = cat;
                        break;
                    case 1:
                        breeds = Enum.GetValues(typeof(DogBreed));
                        DogBreed dogBreed = (DogBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(dogBreed, dogBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Dog dog = new Dog(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 10000));
                        _pets[i] = dog;
                        break;
                    case 2:
                        breeds = Enum.GetValues(typeof(HamsterBreed));
                        HamsterBreed hamsterBreed = (HamsterBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(hamsterBreed, hamsterBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Hamster hamster = new Hamster(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 2000));
                        _pets[i] = hamster;
                        break;
                    case 3:
                        breeds = Enum.GetValues(typeof(RabbitBreed));
                        RabbitBreed rabbitBreed = (RabbitBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(rabbitBreed, rabbitBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Rabbit rabbit = new Rabbit(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 5000));
                        _pets[i] = rabbit;
                        break;
                    case 4:
                        breeds = Enum.GetValues(typeof(FishBreed));
                        FishBreed fishBreed = (FishBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(fishBreed, fishBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Fish fish = new Fish(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 1500));
                        _pets[i] = fish;
                        break;
                    case 5:
                        breeds = Enum.GetValues(typeof(TurtleBreed));
                        TurtleBreed turtleBreed = (TurtleBreed)breeds.GetValue(random.Next(breeds.Length));
                        breed = new Breed(turtleBreed, turtleBreed.ToString(), random.Next(2, 4), random.Next(2, 4), random.Next(5, 8),
                            random.Next(5, 8));
                        Turtle turtle = new Turtle(name, size, random.Next(2, 4), breed, vaccine, age, random.Next(500, 5000));
                        _pets[i] = turtle;
                        break;
                }
            }
        }

        private void CreateStuff()
        {
            Random random = new Random();
            string[] names = new string[1000];

            for (int i = 0; i < 1000; i++)
            {
                names[i] = "Name " + i;
            }
            
            Array foodWeights = Enum.GetValues(typeof(FoodWeight));
            Array foodTypes = Enum.GetValues(typeof(FoodType));
            Array sizes = Enum.GetValues(typeof(Size));
            Array toyMaterials = Enum.GetValues(typeof(ToyMaterial));
            Array houseTypes = Enum.GetValues(typeof(HouseType));
            Array petsTypes = Enum.GetValues(typeof(PetType));
            
            for (int i = 0; i < 1000; i++)
            {
                int randomIdx = random.Next(0, names.Length);
                string name = names[randomIdx];
                Size size = (Size)sizes.GetValue(random.Next(sizes.Length));
                PetType petType = (PetType)petsTypes.GetValue(random.Next(petsTypes.Length));

                switch (randomIdx % 3)
                {
                    case 0:
                        FoodWeight foodWeightE = (FoodWeight)foodWeights.GetValue(random.Next(foodWeights.Length));
                        FoodType foodType = (FoodType)foodTypes.GetValue(random.Next(foodTypes.Length));
                        int realWeight = int.Parse(foodWeightE.ToString().Substring(1));
                        
                        Food foodStf = new Food(name, realWeight, petType, foodType, random.Next(50, 500));
                        _stuff[i] = foodStf;
                        break;
                    case 1:
                        HouseType houseType = (HouseType)houseTypes.GetValue(random.Next(houseTypes.Length));
                        House houseStf = new House(name, size, petType, houseType, random.Next(50, 1500));
                        _stuff[i] = houseStf;

                        break;
                    case 2:
                        ToyMaterial toyMaterial = (ToyMaterial)toyMaterials.GetValue(random.Next(toyMaterials.Length));
                        Toy toyStf = new Toy(name, size, petType, toyMaterial, random.Next(50, 800));
                        _stuff[i] = toyStf;

                        break;
                }
            }
        }

        public Shop()
        {
            this._pets = new Pet[1000];
            this._stuff = new Stuff[1000];
            this.CreatePets();
            this.CreateStuff();
        }
    }
}