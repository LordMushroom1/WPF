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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Get_Pet_Click(object sender, RoutedEventArgs e)
        {
            Get_Animal_Type_Window win = new Get_Animal_Type_Window();
            win.Show();
            this.Close();
        }
        
        private void Get_Stuff_Click(object sender, RoutedEventArgs e)
        {
            Get_Stuff_Type_Window win = new Get_Stuff_Type_Window();
            win.Show();
            this.Close();
        }
    }
}
