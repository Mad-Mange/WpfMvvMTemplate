using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1ElliDataContextTestTaBort.Models;

namespace WpfApp1ElliDataContextTestTaBort.ViewModels
{
    public class SettingsViewModel : NotifyEventModel
    {
        private SettingsModel settings;
        public SettingsModel Settings
        {
            get => settings;
            set { settings = value; OnPropertyChanged(); }
        }

        public SettingsViewModel()
        {
            Settings = new SettingsModel();
            Settings.Name = "Im a string from SettingsModel!!!";
        }
    }
}
