using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
namespace chechaton.viewmodels
{
    public class Day : ViewModelBase
    {
        public bool IsFailed { get; set; }
        public bool IsToday, IsNoMonth;
        public bool IsHaveTask { get; set; }
        public bool IsHoliday { get; set; }
        public int CalendarX { get; set; } 
        public int CalendarY { get; set; } 
        public string StrDate { get; set; }

        public Day(bool IsFailed, bool IsToday, bool IsNoMonth, bool IsHaveTask, bool IsHoliday)
        {
            this.IsFailed = IsFailed;
            this.IsToday = IsToday;
            this.IsNoMonth = IsNoMonth;
            this.IsHaveTask = IsHaveTask;
            this.IsHoliday = IsHoliday;
        }

        public Day(int CalendarX, int CalendarY, string StrDate)
        {
            IsToday = false;
            IsNoMonth = false;
            IsHaveTask = false;
            IsFailed = false;
            IsHoliday = false;
            this.CalendarX = CalendarX;
            this.CalendarY = CalendarY;
            this.StrDate = StrDate;
        }
    }

    public class indexVM
    {
        public ObservableCollection<Day> calendary = new ObservableCollection<Day>();

        public indexVM()
        {
            for(int i = 0; i < 35; i++)
            {
                calendary.Add(new Day(i % 7, i / 7, "18 November"));
            }
            calendary[0].IsFailed = false;
        }

    }
}
