using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;


namespace WPF
{
    public partial class All_Stuff_Window : Window
    {
        private Stuff[] _stuff;
        private Shop _shop;
        private StuffParameters _parameters;

        private Boolean StuffIsValid(Stuff stuff, StuffParameters parameters)
        {
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
            
            switch (stuff.Type)
            {
                case StuffType.Food:
                    return parameters.StuffType == StuffType.Food &&
                           food.PetType == parameters.PetType &&
                           food.Weight == int.Parse(parameters.First.ToString().Substring(1)) &&
                           food.FoodType == (FoodType)parameters.Second ;
                    // Вариіант 2 фільтра
                    // return parameters.StuffType == StuffType.Food &&
                    //        (food.PetType == parameters.PetType ||
                    //        food.Weight == int.Parse(parameters.First.ToString().Substring(1)) ||
                    //        food.FoodType == (FoodType)parameters.Second) ;
                
                case StuffType.House:
                // Аналогічно і тут
                    return parameters.StuffType == StuffType.House &&
                           house.PetType == parameters.PetType &&
                           house.HouseType == (HouseType)parameters.First &&
                           house.Size == (Size)parameters.Second ;
                
                case StuffType.Toy:
                // Аналогічно і тут
                    return parameters.StuffType == StuffType.Toy &&
                           toy.PetType == parameters.PetType &&
                           toy.Material == (ToyMaterial)parameters.First &&
                           toy.Size == (Size)parameters.Second ;
            }

            return false;
        }
        private void FillList()
        {
            for (int i = 0; i < _stuff.Length; i++)
            {
                Stuff stuff = _stuff[i];
                CreatePanel(stuff, i + 1);
            }

        }

        private void CreatePanel(Stuff stuff, int index)
        {
            Grid container = new Grid();
            container.Height = 100;
            container.Width = 400;
            Label title = new Label();
            Label stuffType = new Label();
            title.Content = stuff.Name;
            stuffType.Content = stuff.Type;
            title.FontSize = 25;
            stuffType.FontSize = 20;
            stuffType.VerticalAlignment = VerticalAlignment.Center;
            container.Children.Add(title);
            container.Children.Add(stuffType);
            Button viewMoreBtn = new Button();
            viewMoreBtn.Content = "View More";
            viewMoreBtn.TabIndex = index;
            viewMoreBtn.Width = 70;
            viewMoreBtn.Height = 30;
            viewMoreBtn.Click += Open_Modal;
            viewMoreBtn.HorizontalAlignment = HorizontalAlignment.Right;
            viewMoreBtn.VerticalAlignment = VerticalAlignment.Center;
            container.Children.Add(viewMoreBtn);
            Stuff_ListBox.Items.Add(container);
        }
        
        private void Open_Modal(object sender, RoutedEventArgs e)
        {
            Button btnPressed = sender as Button;
            int petIdx = btnPressed.TabIndex;
            Stuff stuff = _stuff[petIdx - 1];
            Window mod_win = new StuffModal(stuff);
            mod_win.Show();
        }
        public All_Stuff_Window(StuffParameters parameters)
        {
            InitializeComponent();
            _parameters = parameters;
            _shop = new Shop();
            _stuff = _shop.Stuff;
            FillList();
            StuffTB.Text = parameters.StuffType.ToString();
            PetTB.Text = parameters.PetType.ToString();
            if (parameters.StuffType == StuffType.Food)
            {
                FirstTB.Text = parameters.First.ToString().Substring(1);
            }
            else
            {
                FirstTB.Text = parameters.First.ToString();
            }
            SecondTB.Text = parameters.Second.ToString();
        }
        
        private void Filter_Stuff_Click(object sender, RoutedEventArgs e)
        {
            Stuff_ListBox.Items.Clear();
            _stuff = _stuff.Where(stuff => StuffIsValid(stuff, _parameters)).ToArray();
            FillList();
        }
    }
}