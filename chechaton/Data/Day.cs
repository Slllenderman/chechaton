using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Data
{
    public class Day
    {
        public bool IsToday { get; set; }
        public bool IsMonth { get; set; }
        public bool IsWeekend { get; set; }
        public bool IsFailed { get; set; }
        public bool IsHaveTask { get; set; }
        public DateTime Date;
        public ObservableCollection<Task> DayTasks = new ObservableCollection<Task>();

        public Day()
        {
            this.IsToday = false;
            this.IsWeekend = false;
            this.IsFailed = false;
            this.IsHaveTask = false;
            this.IsMonth = true;
            this.Date = new DateTime();
        }

        public Day(bool IsToday, bool IsWeekend, bool IsFailed, bool IsHaveTask, DateTime Date, ObservableCollection<Task> tasks)
        {
            this.IsToday = IsToday;
            this.IsWeekend = false;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday) {
                this.IsWeekend = true;
            }
            this.IsFailed = IsFailed;
            this.IsHaveTask = IsHaveTask;
            this.Date = Date;
            this.IsMonth = false;
            tasks.ForEach(element => DayTasks.Add(element));
        }
        
        public void AddTask(Task task)
        {
            DayTasks.Add(task);
        }
    }
}
