using System.Windows.Controls;
using chechaton.viewmodels;

namespace chechaton.views
{
    /// <summary>
    /// Логика взаимодействия для calendar.xaml
    /// </summary>
    public partial class calendar : UserControl
    {
        public calendar()
        {
            InitializeComponent();
            var vm = new indexVM();
            calendarContainer.ItemsSource = vm.calendary;
        }
    }
}
