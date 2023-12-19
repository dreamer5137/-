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
    /// Логика взаимодействия для Квартиры.xaml
    /// </summary>
    public partial class Квартиры : Page
    {
        public Квартиры()
        {
            InitializeComponent();
            GridApar.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().Apartaments.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры_Подробно_Редакт());
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры_Подробно());
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            БИЗЬНЕСь_ИР311Entities.GetContext().DelApar(Convert.ToInt32(txt_ID.Text));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
