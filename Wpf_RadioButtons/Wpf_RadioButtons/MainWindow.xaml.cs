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

namespace Wpf_RadioButtons
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

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks !");
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Complete the Project quickly");
        }
        private void Still_ProgressChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("How much more time needed");
        }
    }
}
