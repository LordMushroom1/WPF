using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;


namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для All_Pets_Window.xaml
    /// </summary>
    public partial class All_Pets_Window : Window
    {
        private Pet[] _pets;
        private Shop _shop;
        private PetParameters _parameters;

        private Boolean PetIsValid(Pet pet, PetParameters parameters)
        {
            return pet.Breed.BreedType.Equals(parameters.BreedType) && 
                   pet.IsVaccinated.Equals(parameters.VaccineType) &&
                   pet.Age.Equals(parameters.AgeType) &&
                   pet.Size.Equals(parameters.SizeType);
            // Вариант 2 фильтра 
            // return pet.Breed.BreedType.Equals(parameters.BreedType) &&
            //        (pet.IsVaccinated.Equals(parameters.VaccineType) ||
            //         pet.Age.Equals(parameters.AgeType) ||
            //         pet.Size.Equals(parameters.SizeType));
        }

        private void FillList()
        {
            for (int i = 0; i < _pets.Length; i++)
            {
                Pet pet = _pets[i];
                CreatePanel(pet, i + 1);
            }

        }

        private void CreatePanel(Pet pet, int index)
        {
            Grid container = new Grid();
            container.Height = 100;
            container.Width = 400;
            Label title = new Label();
            Label animalType = new Label();
            title.Content = pet.Name;
            animalType.Content = pet.Type;
            title.FontSize = 25;
            animalType.FontSize = 20;
            animalType.VerticalAlignment = VerticalAlignment.Center;
            container.Children.Add(title);
            container.Children.Add(animalType);
            Button viewMoreBtn = new Button();
            viewMoreBtn.Content = "View More";
            viewMoreBtn.TabIndex = index;
            viewMoreBtn.Width = 70;
            viewMoreBtn.Height = 30;
            viewMoreBtn.Click += Open_Modal;
            viewMoreBtn.HorizontalAlignment = HorizontalAlignment.Right;
            viewMoreBtn.VerticalAlignment = VerticalAlignment.Center;
            container.Children.Add(viewMoreBtn);
            Pets_ListBox.Items.Add(container);
        }

        public All_Pets_Window(PetParameters parameters)
        {
            InitializeComponent();
            _parameters = parameters;
            _shop = new Shop();
            _pets = _shop.Pets;
            FillList();
            BreedTB.Text = parameters.BreedType.ToString();
            AgeTB.Text = parameters.AgeType.ToString();
            VaccineTB.Text = parameters.VaccineType.ToString();
            SizeTB.Text = parameters.SizeType.ToString();
        }

        private void Open_Modal(object sender, RoutedEventArgs e)
        {
            Button btnPressed = sender as Button;
            int petIdx = btnPressed.TabIndex;
            Pet pet = _pets[petIdx - 1];
            Window mod_win = new PetModal(pet);
            mod_win.Show();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Pets_ListBox.Items.Clear();
            _pets = _pets.Where(pet => PetIsValid(pet, _parameters)).ToArray();
            FillList();
        }
        
    }
}
