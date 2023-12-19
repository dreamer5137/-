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
namespace _1
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Rachet());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new BD());
        }

        private void Redact_Copy_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Дома());
        }

        private void Redact_Copy1_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры());
        }
    }
}
