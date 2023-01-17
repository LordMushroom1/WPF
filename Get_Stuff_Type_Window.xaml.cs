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
    /// Логика взаимодействия для Get_Stuff_Type_Window.xaml
    /// </summary>
    public partial class Get_Stuff_Type_Window : Window
    {
        public Get_Stuff_Type_Window()
        {
            InitializeComponent();
            foreach(string name in Enum.GetNames(typeof(StuffType)))
            {
                stuffTypeCmb.Items.Add(name);
            }
            stuffTypeCmb.SelectedItem = "Food";
        }
        
        private void Choose_Stuff_Type(object sender, RoutedEventArgs e)
        {
            StuffType stuffType = StuffType.Food;

            switch (stuffTypeCmb.Text)
            {
                case "Food":
                    stuffType = StuffType.Food;
                    break;
                case "House":
                    stuffType = StuffType.House;
                    break;
                case "Toy":
                    stuffType = StuffType.Toy;
                    break;
            }

            Stuff_Parameters_Window stuffParametersWindow = new Stuff_Parameters_Window(stuffType);

            stuffParametersWindow.Show();
            this.Close();
        }
    }
}
