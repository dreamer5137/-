using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для Rachet.xaml
    /// </summary>
    public partial class Rachet : Page
    {
        public Rachet()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().rez1.ToList();
        }
        static string connectionString = "data source=1-318-CLS-11;initial catalog=БИЗЬНЕСь_ИР311;user id=sa;password=123;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal
                Param1 = Convert.ToDecimal(param1.Text),
                Param2 = Convert.ToDecimal(param2.Text),
                Param3 = Convert.ToDecimal(param3.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().RachetZk1(Param1, Param2, Param3);
            DataGrid1.ItemsSource = null;
            DataGrid1.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().rez1.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            decimal
                Param1 = Convert.ToDecimal(param1.Text),
                Param2 = Convert.ToDecimal(param2.Text),
                Param3 = Convert.ToDecimal(param3.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().RachetHome2(Param1, Param2, Param3);
            DataGrid1.ItemsSource = null;
            DataGrid1.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().rez2.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            decimal
                Param1 = Convert.ToDecimal(param1.Text),
                Param2 = Convert.ToDecimal(param2.Text),
                Param3 = Convert.ToDecimal(param3.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().RachetKV3(Param1, Param2, Param3);
            DataGrid1.ItemsSource = null;
            DataGrid1.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().rez33.ToList();
        }
    }

}



