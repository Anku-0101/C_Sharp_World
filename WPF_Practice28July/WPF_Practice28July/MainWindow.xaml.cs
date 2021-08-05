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

namespace WPF_Practice28July
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ResourceDictionary abc;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            ButtonControl();
        }

        private void ButtonControl()
        {
            btn.Height = 30;
            btn.Width = 100;
            btn.Content = "Click the button";

            this.Resources["MyCustomResource"] = new Style(typeof(Button));
            btn.Style.TargetType = typeof(Button);
            Style mystyle = new Style(typeof(Button));
            Trigger trigger = new Trigger();
             
             
                
            
        }
    }
}
