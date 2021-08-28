using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Practice_18Aug.Command
{
    class RelayCommand : ICommand
    {
        Action<object> executeMethod;
        Func<object, bool> canExecuteMethod;

        public RelayCommand(Action<object> ExecuteMethod, Func<object, bool> CanExecuteMethod)
        {
            this.executeMethod = ExecuteMethod;
            this.canExecuteMethod = CanExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if(canExecuteMethod == null)
            {
                return true;
            }
            else
            {
                return canExecuteMethod(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
