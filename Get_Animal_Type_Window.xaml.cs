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
    /// Логика взаимодействия для Get_Animal_Type_Window.xaml
    /// </summary>
    public partial class Get_Animal_Type_Window : Window
    {

        public Get_Animal_Type_Window()
        {
            InitializeComponent();
            foreach(string name in Enum.GetNames(typeof(PetType)))
            {
                animalTypeComboBox.Items.Add(name);
            }
            animalTypeComboBox.SelectedItem = "Dog";
        }

        private void Choose_Animal_Type(object sender, RoutedEventArgs e)
        {
            PetType animalType = PetType.Dog;

            switch (animalTypeComboBox.Text)
            {
                case "Dog":
                    animalType = PetType.Dog;
                    break;
                case "Cat":
                    animalType = PetType.Cat;
                    break;
                case "Turtle":
                    animalType = PetType.Turtle;
                    break;
                case "Rabbit":
                    animalType = PetType.Rabbit;
                    break;
                case "Fish":
                    animalType = PetType.Fish;
                    break;
                case "Hamster":
                    animalType = PetType.Hamster;
                    break;
            }

            Pet_Parameters_Window petParametersWindow = new Pet_Parameters_Window(animalType);

            petParametersWindow.Show();
            this.Close();
        }
    }
}
