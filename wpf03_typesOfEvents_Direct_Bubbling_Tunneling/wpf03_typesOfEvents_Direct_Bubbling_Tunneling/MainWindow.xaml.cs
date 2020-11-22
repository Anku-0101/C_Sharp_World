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

namespace wpf03_typesOfEvents_Direct_Bubbling_Tunneling
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

        //Whether we click outer or inner button we get outer button clicked as this forms a bubbling event
        // i.e it travels up the visual tree. 
        private void outerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Outer Button Clicked");
        }

        //If we click inner button then only title of window will change, it demonstrates bubble travels from 
        //top to down in a visual tree, like what bubble does
        private void innerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Changed title";
        }

        // Tunneling effect, it travels from top to down in the visual tree like what tunnel does
        private void outerbutton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = label.Content + "Outer Button; ";
        }

        private void innerbutton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = label.Content + "Inner Button; ";
        }
    }
}
