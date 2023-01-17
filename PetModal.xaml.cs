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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для PetModal.xaml
    /// </summary>
    public partial class PetModal : Window
    {
        public PetModal(Pet pet)
        {
            InitializeComponent();
            NameTB.Text = pet.Name;
            AnimalClassTB.Text = pet.AnimalClass.ToString();
            AnimalTypeTB.Text = pet.Type.ToString();
            BreedTB.Text = pet.Breed.BreedName;
            BreedAWTB.Text = "Average weight : " + pet.Breed.AverageWeight;
            BreedAHTB.Text = "Average height : " + pet.Breed.AverageHeight;
            BreedMWTB.Text = "Max weight : " + pet.Breed.MaxWidth;
            BreedMHTB.Text = "Max weight : " + pet.Breed.MaxHeight;
            AgeTB.Text = "Age : " + pet.Age;
            SizeTB.Text = "Size : " + pet.Size;
            WeightTB.Text = "Weight : " + pet.Weight;
            PriceTB.Text = "Price : " + pet.Price;
        }
    }
}
