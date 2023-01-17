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
    /// Логика взаимодействия для Pet_Parameters_Window.xaml
    /// </summary>

    public partial class Pet_Parameters_Window : Window
    {
        private PetType _animalType;
        private void FillComboBox(ComboBox cmbBox, string[] items)
        {
            foreach(string item in items)
            {
                cmbBox.Items.Add(item);
            }

            cmbBox.SelectedItem = items[0];
        }

        public Pet_Parameters_Window(PetType animalType)
        {
            InitializeComponent();
            _animalType = animalType;
            string[] breedsList = { };
            string[] ageList = Enum.GetNames(typeof(Age));
            string[] sizeList = Enum.GetNames(typeof(Size));
            string[] vaccineList = Enum.GetNames(typeof(VaccineType));
            switch (animalType)
            {
                case PetType.Dog:
                    breedsList = Enum.GetNames(typeof(DogBreed));
                    break;
                case PetType.Cat:
                    breedsList = Enum.GetNames(typeof(CatBreed));
                    break;
                case PetType.Turtle:
                    breedsList = Enum.GetNames(typeof(TurtleBreed));
                    break;
                case PetType.Rabbit:
                    breedsList = Enum.GetNames(typeof(RabbitBreed));
                    break;
                case PetType.Fish:
                    breedsList = Enum.GetNames(typeof(FishBreed));
                    break;
                case PetType.Hamster:
                    breedsList = Enum.GetNames(typeof(HamsterBreed));
                    break;
            }

            this.FillComboBox(breed_ComboBox, breedsList);

            this.FillComboBox(vaccine_ComboBox, vaccineList);

            this.FillComboBox(age_ComboBox, ageList);

            this.FillComboBox(size_ComboBox, sizeList);
        }

        private void Get_Parameters_Click(object sender, RoutedEventArgs e)
        {
            string breed = breed_ComboBox.SelectedItem.ToString();
            string vaccine = vaccine_ComboBox.SelectedItem.ToString();
            string age = age_ComboBox.SelectedItem.ToString();
            string size = size_ComboBox.SelectedItem.ToString();

            VaccineType vacType = (VaccineType)Enum.Parse(typeof(VaccineType), vaccine); 
            Age ageType = (Age)Enum.Parse(typeof(Age), age); 
            Size sizeType = (Size)Enum.Parse(typeof(Size), size);
            PetParameters parameters = null;
            
            switch (_animalType)
            {
                case PetType.Dog:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(DogBreed), breed), sizeType, ageType, vacType);
                    break;
                case PetType.Cat:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(CatBreed), breed), sizeType, ageType, vacType);
                    break;
                case PetType.Turtle:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(TurtleBreed), breed), sizeType, ageType, vacType);
                    break;
                case PetType.Rabbit:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(RabbitBreed), breed), sizeType, ageType, vacType);
                    break;
                case PetType.Fish:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(FishBreed), breed), sizeType, ageType, vacType);
                    break;
                case PetType.Hamster:
                    parameters = new PetParameters((Enum)Enum.Parse(typeof(HamsterBreed), breed), sizeType, ageType, vacType);
                    break;
            }
            
            All_Pets_Window allPetsWindow = new All_Pets_Window(parameters);
            allPetsWindow.Show();
            this.Close();
        }
    }
}
