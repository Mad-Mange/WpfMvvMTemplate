using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1ElliDataContextTestTaBort.ViewModels;

namespace WpfApp1ElliDataContextTestTaBort.Commands
{
    class UpdateViewCommand : ICommand
    {
        private HandleViewModel _viewModel;

        public UpdateViewCommand(HandleViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Main")
            {
                _viewModel.SelectedViewModel = new MainViewViewModel();
            }
            else if(parameter.ToString() == "Settings")
            {
                _viewModel.SelectedViewModel = new SettingsViewModel();
            }
        }
    }
}
