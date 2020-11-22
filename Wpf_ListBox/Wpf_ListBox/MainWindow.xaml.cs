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

namespace Wpf_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            
            matches.Add(new Match() { Team1 = "France", Team2 = "Germany", Score1 = 3, Score2 = 2, Completion = 80 });
            matches.Add(new Match() { Team1 = "Africa", Team2 = "Australia", Score1 = 9, Score2 = 4, Completion = 60 });
            matches.Add(new Match() { Team1 = "Itly", Team2 = "Japan", Score1 = 0, Score2 = 1, Completion = 40 });
            matches.Add(new Match() { Team1 = "Canada", Team2 = "India", Score1 = 0, Score2 = 0, Completion = 10 });
            matches.Add(new Match() { Team1 = "USA", Team2 = "China", Score1 = 12, Score2 = 9, Completion = 120 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: \n"
                                + ((Match)lbMatches.SelectedItem).Team1 + " : " +
                                ((Match)lbMatches.SelectedItem).Score1 + " \n" +
                                ((Match)lbMatches.SelectedItem).Team2 + " : " +
                                ((Match)lbMatches.SelectedItem).Score2 + " \n"); 
                                
            }
            else
            {
                MessageBox.Show("Select a match to get the information");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
