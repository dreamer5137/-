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
    /// Логика взаимодействия для Дома.xaml
    /// </summary>
    public partial class Дома : Page
    {
        public Дома()
        {
            InitializeComponent();
            datagridhome.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().Houses.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Дома_Подробно_Редакт());
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Дома_Подробно());
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            БИЗЬНЕСь_ИР311Entities.GetContext().DelHome(Convert.ToInt32(txt_ID.Text));
        }

        private void aparts_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры());
        }
    }
}
