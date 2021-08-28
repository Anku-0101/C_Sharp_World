using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandsInWPF
{
    public class ViewModel
    {
        public ICommand myCommand { get; set; }

        public ViewModel()
        {
            myCommand = new Command(Execute_, CanExecute_);
        }

        private void Execute_(object parameter)
        {
            MessageBox.Show("Displaying message without code behind");
        }

        private bool CanExecute_(object parameter)
        {
            return true;
        }
    }
}
