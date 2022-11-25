using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chechaton.viewmodels
{

    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }

    public class Day
    {
        public bool IsFailed, IsToday, IsNoMonth, IsHaveTask, IsHoliday;

        public Day(bool IsFailed, bool IsToday, bool IsNoMonth, bool IsHaveTask, bool IsHoliday)
        {
            this.IsFailed = IsFailed;
            this.IsToday = IsToday;
            this.IsNoMonth = IsNoMonth;
            this.IsHaveTask = IsHaveTask;
            this.IsHoliday = IsHoliday;
        }

        public Day()
        {
            IsToday = false;
            IsNoMonth = false;
            IsHaveTask = false;
            IsFailed = false;
            IsHoliday = false;
        }
    }

    public class indexVM
    {
        public ObservableCollection<Day> calendary = new ObservableCollection<Day>();

        public indexVM()
        {
            for(int i = 0; i < 35; i++)
            {
                calendary.Add(new Day());
            }
            calendary[0].IsHaveTask = true;
        }

        static public void CheckBoxAction(object paramspamspams)
        {
            int a = 0;
            int b = 0;
        }

        static public RelayCommand checkboxcom = new RelayCommand(CheckBoxAction);
    }
}
