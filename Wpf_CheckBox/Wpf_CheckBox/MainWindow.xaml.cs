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

namespace Wpf_CheckBox
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

        private void cbAllToppings_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToppings.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushroom.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
        }

        private void cbSingle_Checked(object sender, RoutedEventArgs e)
        {
            //Uncomment the line below to see the null state for All , i.e true, false, null (TriState)
            //cbAllToppings.IsChecked = null;
            
            if((cbSalami.IsChecked == true) && (cbMozzarella.IsChecked == true) && (cbMushroom.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbMushroom.IsChecked == false))
            {
                cbAllToppings.IsChecked = false;
            }
        }
    }
}
