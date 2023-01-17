namespace WPF
{
    public class Stuff
    {
        protected PetType _petType;
        protected StuffType _type;
        protected double _price;
        protected string _name;

        public PetType PetType
        {
            get { return _petType; }
        }

        public StuffType Type
        {
            get { return _type; }
        }

        public double Price
        {
            get { return _price; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}