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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.View;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Employee_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmployee wEmployee = new WindowEmployee();
            wEmployee.Show();
        }
        private void Role_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRole wRole = new WindowRole();
            wRole.Show();
        }
    }
}
