using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Data
{
    class DayManager
    {
        public string name = "json.txt";
        public string path = "..//..//..//";
        public TaskManager taskManager;
        public int AppBlock = 35;

        public DayManager()
        {
            name = "json.json";
            taskManager = new TaskManager(name);
        }

        public DayManager(string fileName)
        {
            name = fileName;
            taskManager = new TaskManager(name);
        }

        public void SetPath(string newPath)
        {
            path = newPath;
            taskManager.SetPath(path);
        }

        public Day GetNearestDayWithTask(DateTime Date)
        {
            Day nearestDay = new Day();
            if (taskManager.tasks.Count == 0)
                return null;

            List<Task> nextTasks = new List<Task>();
            taskManager.tasks.ForEach(element =>
            {
                if (element.EndDateTime >= Date)
                    nextTasks.Add(element);
            });

            if (nextTasks.Count == 0)
                return null;

            nextTasks.Sort((el1, el2) =>
            {
                return (el2.EndDateTime > el1.EndDateTime) ? 1 : 0;
            });
            Task firstTask = nextTasks[0];
            ObservableCollection<Task> dayTasks = new ObservableCollection<Task>();
            taskManager.tasks.ForEach(element =>
            {
                if (element.EndDateTime.Year == firstTask.EndDateTime.Year)
                    if (element.EndDateTime.Month == firstTask.EndDateTime.Month)
                        if (element.EndDateTime.Day == firstTask.EndDateTime.Day)
                            dayTasks.Add(element);
            });
            bool isToday = (Date.Year == firstTask.EndDateTime.Year && Date.Month == firstTask.EndDateTime.Month && Date.Day == firstTask.EndDateTime.Day);
            bool isHaveTask = (dayTasks.Count != 0);
            bool isFailed = false;
            dayTasks.ForEach(element => { if (element.IsFailed == true) isFailed = true; });
            nearestDay = new Day(isToday, false, isFailed, isHaveTask, firstTask.EndDateTime, dayTasks);
            return nearestDay; 
        }

        public ObservableCollection<Day> GetDaysForOneMonth(int Month, int Year, int FirstDay = 1, int EndDay = 30)
        {
            ObservableCollection<Day> days = new ObservableCollection<Day>();
            ObservableCollection<Task> MonthTasks = new ObservableCollection<Task>();
            taskManager.tasks.ForEach(element =>
            {
                if (element.EndDateTime.Month == Month && element.EndDateTime.Year == Year)
                    MonthTasks.Add(element);
            });
            for (int day = FirstDay; day <= EndDay; day++)
            {
                ObservableCollection<Task> DayTasks = new ObservableCollection<Task>();
                MonthTasks.ForEach(element =>
                {
                    if (element.EndDateTime.Day == day)
                        DayTasks.Add(element);
                });
                DateTime CurrentDate = new DateTime(Year, Month, day);
                DateTime today = DateTime.Today;
                bool isToday = (today.Year == Year && today.Month == Month && today.Day == day);
                bool isHaveTask = (DayTasks.Count != 0);
                bool isFailed = false;
                DayTasks.ForEach(element => { if (element.IsFailed == true) isFailed = true; });
                Day CurrentDay = new Day(isToday, false, isFailed, isHaveTask, CurrentDate, DayTasks);
                days.Add(CurrentDay);
            }
            return days;
        }

        public ObservableCollection<Day> GetCalendary(int Month, int Year)
        {
            ObservableCollection<Day> CurrentBlockDays = new ObservableCollection<Day>();
            DateTime firstDay = new DateTime(Year, Month, 1);
            int needNumberOfDays = DateTime.DaysInMonth(Year, Month);
            if (firstDay.DayOfWeek != DayOfWeek.Monday)
            {
                int number = firstDay.DayOfWeek - DayOfWeek.Monday;
                int PreviousMonth = (Month == 1) ? 12 : Month - 1;
                int updateYear = (Month == 1) ? Year - 1 : Year;
                int endDay = DateTime.DaysInMonth(updateYear, PreviousMonth);
                ObservableCollection<Day> PreviousMonthDays = GetDaysForOneMonth(PreviousMonth, updateYear, endDay - number + 1, endDay);
                PreviousMonthDays.ForEach(element => CurrentBlockDays.Add(element));
            }
            if (CurrentBlockDays.Count + DateTime.DaysInMonth(Year, Month) > AppBlock)
                needNumberOfDays = AppBlock - CurrentBlockDays.Count;
            ObservableCollection<Day> CurrentMonthDays = GetDaysForOneMonth(Month, Year, 1, needNumberOfDays);
            CurrentMonthDays.ForEach(element => CurrentBlockDays.Add(element));
            if (CurrentBlockDays.Count < AppBlock)
            {
                int NextMonth = (Month == 12) ? 1 : Month + 1;
                int updateYear = (Month == 12) ? Year + 1 : Year;
                ObservableCollection<Day> NextMonthDays = GetDaysForOneMonth(NextMonth, updateYear, 1, AppBlock - CurrentBlockDays.Count);
                NextMonthDays.ForEach(element => CurrentBlockDays.Add(element));
            }
            return CurrentBlockDays;
        }

        public Day GetDay(DateTime Date)
        {
            ObservableCollection<Task> tasks = new ObservableCollection<Task>();
            taskManager.tasks.ForEach(element => 
            {
                if (element.EndDateTime.Year == Date.Year && element.EndDateTime.Month == Date.Month && element.EndDateTime.Day == Date.Day)
                    tasks.Add(element);
            });
            DateTime today = DateTime.Today;
            bool isToday = (today.Year == Date.Year && today.Month == Date.Month && today.Day == Date.Day);
            bool isHaveTask = (tasks.Count != 0);
            bool isFailed = false;
            tasks.ForEach(element => { if (element.IsFailed == true) isFailed = true; });
            Day day = new Day(isToday, false, isFailed, isHaveTask, Date, tasks);
            return day;
        }
    }
}
