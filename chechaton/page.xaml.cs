using Notifications.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notifications {
    /// <summary>
    /// Логика взаимодействия для page.xaml
    /// </summary>
    public partial class page : Window {
        public page() {
            InitializeComponent();
            date.Content = DateTime.Today.ToString("M");
        }
        private void add_Click(object sender, RoutedEventArgs e) {
            //fullTaskList.Visibility = Visibility.Hidden;
        }


        private void closeThikk_MouseEnter(object sender, MouseEventArgs e) {

            DoubleAnimation op = new DoubleAnimation();
            op.From = 0;
            op.To = 1;
            op.Duration = TimeSpan.FromSeconds(0.3);
            thikk.BeginAnimation(closeThikk.OpacityProperty, op);

        }

        private void closeThin_MouseEnter(object sender, MouseEventArgs e) {
        }

        private void thikk_MouseLeave(object sender, MouseEventArgs e) {

            DoubleAnimation op = new DoubleAnimation();
            op.From = 1;
            op.To = 0;
            op.Duration = TimeSpan.FromSeconds(0.3);
            thikk.BeginAnimation(closeThikk.OpacityProperty, op);

        }

        private void addButton_Loaded(object sender, RoutedEventArgs e) {

        }

        private void addButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            //addTask addtask = new addTask();
            //addtask.Show();
        }

        private void thikk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            this.Hide();
        }
    }
}
