using System;
using System.Windows;

namespace WPF
{
    public partial class StuffModal : Window
    {
        public StuffModal(Stuff stuff)
        {
            InitializeComponent();
            Food food = null;
            House house = null;
            Toy toy = null;

            switch (stuff.Type)
            {
                case StuffType.Food:
                    food = stuff as Food;
                    break;
                case StuffType.House:
                    house = stuff as House;
                    break;
                case StuffType.Toy:
                    toy = stuff as Toy;
                    break;
            }
            
            NameTB.Text = stuff.Name;
            StuffTypeTB.Text = stuff.Type.ToString();
            PetTypeTB.Text = stuff.PetType.ToString();
            switch (stuff.Type)
            {
                case StuffType.Food:
                    FirstParTB.Text = food.FoodType.ToString();
                    SecondParTB.Text = food.Weight.ToString();        
                    break;
                
                case StuffType.House:
                    FirstParTB.Text = house.HouseType.ToString();
                    SecondParTB.Text = house.Size.ToString();
                    break;
                
                case StuffType.Toy:
                    FirstParTB.Text = toy.Material.ToString();
                    SecondParTB.Text = toy.Size.ToString();
                    break;
            }
            
            PriceTB.Text = "Price : " + stuff.Price;
            
        }
    }
}