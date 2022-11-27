using System.Windows.Controls;
using System.Windows.Data;
using chechaton.templates;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Media;

using Data;
using System;
using Notifications;

namespace chechaton.views
{
    /// <summary>
    /// Логика взаимодействия для calendar.xaml
    /// </summary>
    

    public partial class calendar : UserControl
    {

        public void Button_click(object sender, RoutedEventArgs e) {
            page Page = new page();
            Page.Show();
        }

        static Brush? SelectBackColor(Day day)
        {
            var converter = new BrushConverter();
            if (day.IsMonth)
                return (Brush?)converter.ConvertFromString("#EBEAEA");
            if ((day.IsWeekend) && (day.IsHaveTask))
                return (Brush?)converter.ConvertFromString("#FFE142");
            if(day.IsHaveTask)
                return (Brush?)converter.ConvertFromString("#FFE458");
            if(day.IsWeekend)
                return (Brush?)converter.ConvertFromString("#B2FF3D");
            return (Brush?)converter.ConvertFromString("#B8F956");
        }

        void FillGrid(ObservableCollection<Day> month)
        {
            var btarr = new List<Button>() 
            { Bt1, Bt2, Bt3, Bt4, Bt5, Bt6, Bt7, 
              Bt8, Bt9, Bt10, Bt11, Bt12, Bt13, Bt14,
              Bt15, Bt16, Bt17, Bt18, Bt19, Bt20, Bt21,
              Bt22, Bt23, Bt24, Bt25, Bt26, Bt27, Bt28,
              Bt29, Bt30, Bt31, Bt32, Bt33, Bt34, Bt35
            };

            for(int i = 0; i < 35; i++)
            {
                month[i].IsMonth = (DateTime.Now.ToString("MMMM") != month[i].Date.ToString("MMMM"));
                btarr[i].Background = SelectBackColor(month[i]);
                btarr[i].Content = month[i].Date.ToString("M");
                btarr[i].SetValue(ButtonProperties.IsFailedProperty, month[i].IsFailed);
                btarr[i].SetValue(ButtonProperties.IsTodayProperty, month[i].IsToday);
                btarr[i].SetValue(ButtonProperties.IsHaveTaskProperty, month[i].IsHaveTask);
                btarr[i].Click += Button_click;
            }
        }

        public calendar()
        {
            InitializeComponent();
            DayManager dm = new DayManager();
            ObservableCollection < Day > calendar = dm.GetCalendary(11, 2022);
            FillGrid(calendar);
        }
    }
}
