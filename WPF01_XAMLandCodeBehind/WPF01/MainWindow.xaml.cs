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

namespace WPF01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //The commented part in MainWindow.xaml does the same thing, this example 
            //shows how the xaml part is converted internally into C# cod, 
            //and we can also do the same operations as in xaml file in our code behind class. 
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button button = new Button();
            button.Width = 200;
            button.Height = 100;
            button.FontSize = 24;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock text = new TextBlock();

            text.Text = "Multi";
            text.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(text);

            text = new TextBlock();
            text.Text = "Color";
            text.Foreground = Brushes.Red;
            wrapPanel.Children.Add(text);

            text = new TextBlock();
            text.Text = "Button";
            text.Foreground = Brushes.Green;
            wrapPanel.Children.Add(text);

            button.Content = wrapPanel;
            grid.Children.Add(button);
        }
    }
}
