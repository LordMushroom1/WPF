namespace WPF
{
    public class Food : Stuff
    {

        private int _weight;
        private FoodType _foodType;
        
        public int Weight
        {
            get { return _weight; }
        }
        
        public FoodType FoodType
        {
            get { return _foodType; }
        }
        
        public Food(string name, int weight, PetType petType, FoodType foodType,  double price)
        {
            _name = name;
            _weight = weight;
            _price = price;
            _type = StuffType.Food;
            _foodType = foodType;
            _petType = petType;
        }
    }
}