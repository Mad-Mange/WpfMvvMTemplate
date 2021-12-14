using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1ElliDataContextTestTaBort.Models
{
    public class SettingsModel : NotifyEventModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
    }
}
