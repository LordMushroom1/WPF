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
    /// Логика взаимодействия для Stuff_Parameters_Window.xaml
    /// </summary>
    public partial class Stuff_Parameters_Window : Window
    {
        private void FillComboBox(ComboBox cmbBox, string[] items)
        {
            foreach (string item in items)
            {
                cmbBox.Items.Add(item);
            }

            cmbBox.SelectedItem = items[0];
        }

        private StuffType _stuffType;
        
        public Stuff_Parameters_Window(StuffType stuffType)
        {
            InitializeComponent();
            _stuffType = stuffType;
            string[] petsList = Enum.GetNames(typeof(PetType));
            FillComboBox(petTypeCmb, petsList);
            
            switch (stuffType)
            {
                case StuffType.Food:
                    string[] weightList = {"50", "100", "150"};
                    string[] sizeList;
                    FillComboBox(firstCmb, weightList);
                    
                    string[] foodTypeList = Enum.GetNames(typeof(FoodType));
                    FillComboBox(secondCmb, foodTypeList);
                    break;
                case StuffType.House:
                    string[] houseTypeList = Enum.GetNames(typeof(HouseType));
                    FillComboBox(firstCmb, houseTypeList);
                    
                    sizeList = Enum.GetNames(typeof(Size));
                    FillComboBox(secondCmb, sizeList);
                    break;
                case StuffType.Toy:
                    string[] materialList = Enum.GetNames(typeof(ToyMaterial));
                    FillComboBox(firstCmb, materialList);
                    
                    sizeList = Enum.GetNames(typeof(Size));
                    FillComboBox(secondCmb, sizeList);
                    break;
            }
            
        }
        
        private void Get_Stuff_Parameters_Click(object sender, RoutedEventArgs e)
        {
            string pet = petTypeCmb.SelectedItem.ToString();
            string first = firstCmb.SelectedItem.ToString();
            string second = secondCmb.SelectedItem.ToString();

            PetType petType = (PetType)Enum.Parse(typeof(PetType), pet); 
            Enum firstPar = null; 
            Enum secondPar = null; 
            switch (_stuffType)
            {
                case StuffType.Food:
                    firstPar = (FoodWeight)Enum.Parse(typeof(FoodWeight), "w" + first); 
                    secondPar = (FoodType)Enum.Parse(typeof(FoodType), second);
                    break;
                case StuffType.House:
                    firstPar = (HouseType)Enum.Parse(typeof(HouseType), first); 
                    secondPar = (Size)Enum.Parse(typeof(Size), second);
                    break;
                case StuffType.Toy:
                    firstPar = (ToyMaterial)Enum.Parse(typeof(ToyMaterial), first); 
                    secondPar = (Size)Enum.Parse(typeof(Size), second);
                    break;
            }
            StuffParameters parameters = new StuffParameters(_stuffType, petType, firstPar, secondPar);
            All_Stuff_Window allStuffWindow = new All_Stuff_Window(parameters);
            allStuffWindow.Show();
            this.Close();
        }
    }
}
