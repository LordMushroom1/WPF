namespace WPF
{
    public class Toy : Stuff
    {

        private Size _toySize;
        private ToyMaterial _toyMaterial;

        public Size Size
        {
            get { return _toySize; }
        }

        public ToyMaterial Material
        {
            get { return _toyMaterial; }
        }
        
        public Toy(string name, Size size, PetType petType, ToyMaterial material, double price)
        {
            _name = name;
            _toySize = size;
            _price = price;
            _type = StuffType.Toy;
            _toyMaterial = material;
            _petType = petType;
        }
    }
}