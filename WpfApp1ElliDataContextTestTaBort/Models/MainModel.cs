using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1ElliDataContextTestTaBort.Commands;

namespace WpfApp1ElliDataContextTestTaBort.Models
{
    public class MainModel : NotifyEventModel
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

    }
}
