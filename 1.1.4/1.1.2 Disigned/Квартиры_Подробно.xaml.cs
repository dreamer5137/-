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
    /// Логика взаимодействия для Квартиры_Подробно.xaml
    /// </summary>
    public partial class Квартиры_Подробно : Page
    {
        public Квартиры_Подробно()
        {
            InitializeComponent();
            DGridGKPod.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().Apartaments.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            FrameC.MainFrame.Navigate(new Квартиры_Подробно_Редакт());
        }
    }
}
