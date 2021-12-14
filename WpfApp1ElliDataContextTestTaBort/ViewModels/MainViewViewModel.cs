using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1ElliDataContextTestTaBort.Models;

namespace WpfApp1ElliDataContextTestTaBort.ViewModels
{
    public class MainViewViewModel : NotifyEventModel
    {
        private MainModel _main;

        public MainModel Main
        {
            get { return _main; }
            set { _main = value; }
        }

        public MainViewViewModel()
        {
            Main = new MainModel();
            Main.Date = DateTime.Now;
        }
    }
}
