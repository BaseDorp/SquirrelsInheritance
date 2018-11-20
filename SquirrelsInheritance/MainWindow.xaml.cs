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

namespace SquirrelsInheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Animal> animal = new List<Animal>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Name.Text = " ";
        }

        private void tb_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == " ")
            {
                tb_Name.Text = "Name";
            }
        }

        private void tb_Facts_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Facts.Text = " ";
        }

        private void tb_Facts_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_Facts.Text == " ")
            {
                tb_Facts.Text = "Enter cool fact";
            }
        }

        private void bt_Squirrel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_Chipmunk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
