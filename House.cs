namespace WPF
{
    public class House : Stuff
    {

        private Size _houseSize;
        private HouseType _houseType;

        public Size Size
        {
            get { return _houseSize; }
        }

        public HouseType HouseType
        {
            get { return _houseType; }
        }
        
        public House(string name, Size size, PetType petType, HouseType houseType, double price)
        {
            _name = name;
            _houseSize = size;
            _price = price;
            _type = StuffType.House;
            _houseType = houseType;
            _petType = petType;
        }
    }
}