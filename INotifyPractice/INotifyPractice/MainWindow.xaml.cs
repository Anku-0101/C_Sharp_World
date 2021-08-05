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

namespace INotifyPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person PersonObj { get; set; }
        public MainWindow()
        {
            PersonObj = new Person();
            PersonObj.FirstName = "Anku";
            PersonObj.LastName = "Kumar";

            InitializeComponent();
            this.DataContext = this;
        }
    }
}
