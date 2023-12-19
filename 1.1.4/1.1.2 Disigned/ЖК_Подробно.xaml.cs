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
    /// Логика взаимодействия для ЖК_Подробно.xaml
    /// </summary>
    public partial class ЖК_Подробно : Page
    {
        public ЖК_Подробно()
        {
            InitializeComponent();
            DGridGKPod.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().ResidentialComplexes.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                БИЗЬНЕСь_ИР311Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridGKPod.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().ResidentialComplexes.ToList();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
