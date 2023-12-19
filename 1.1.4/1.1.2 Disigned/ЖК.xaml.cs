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
    /// Логика взаимодействия для BD.xaml
    /// </summary>
    public partial class BD : Page
    {
        public BD()
        {
            InitializeComponent();
            DgridRez.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().ResidentialComplexes.ToList();
        }


        private void add_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new ЖК_Подробно_Редакт());
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            БИЗЬНЕСь_ИР311Entities.GetContext().DelResident(Convert.ToInt32(txt_res.Text));
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new ЖК_Подробно());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void houses_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры());
        }
    }
}
