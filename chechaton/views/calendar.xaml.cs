using System.Windows.Controls;
using System.Windows.Data;
using chechaton.viewmodels;
using chechaton.templates;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Media;

namespace chechaton.views
{
    /// <summary>
    /// Логика взаимодействия для calendar.xaml
    /// </summary>
    

    public partial class calendar : UserControl
    {
        static Brush? SelectBackColor(Day day)
        {
            var converter = new BrushConverter();
            if (day.IsNoMonth)
                return (Brush?)converter.ConvertFromString("#EBEAEA");
            if ((day.IsHoliday) && (day.IsHaveTask))
                return (Brush?)converter.ConvertFromString("#FFE142");
            if(day.IsHaveTask)
                return (Brush?)converter.ConvertFromString("#FFE458");
            if(day.IsHoliday)
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
                btarr[i].Background = SelectBackColor(month[i]);
                btarr[i].Content = month[i].StrDate;
                btarr[i].SetValue(ButtonProperties.IsFailedProperty, month[i].IsFailed);
                btarr[i].SetValue(ButtonProperties.IsTodayProperty, month[i].IsToday);
                btarr[i].SetValue(ButtonProperties.IsHaveTaskProperty, month[i].IsHaveTask);
            }
        }

        public calendar()
        {
            InitializeComponent();
            var vm = new indexVM();
            FillGrid(vm.calendary);
        }
    }
}
