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
            viewbox.MouseLeftButtonDown += new MouseButtonEventHandler(Dragging);
        }

        void Dragging(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void CloseClick(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
