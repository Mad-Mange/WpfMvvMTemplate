using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1ElliDataContextTestTaBort.Commands;
using WpfApp1ElliDataContextTestTaBort.Models;

namespace WpfApp1ElliDataContextTestTaBort.ViewModels
{
    /// <summary>
    /// Handles Changes Between Diffrent Views
    /// </summary>
    public class HandleViewModel : NotifyEventModel
    {
        private NotifyEventModel _selectedViewModel = new MainViewViewModel();
        public NotifyEventModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        
        public ICommand UpdateViewCommand { get; set; }
        //public ICommand MainCommands { get; set; }
        //public ICommand SettingsCommands { get; set; }

        public HandleViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            //MainCommands = new MainCommands();
            //SettingsCommands = new SettingsCommands();
        }
    }
}
