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
using System.Xml.Linq;

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для Дома_Подробно_Редакт.xaml
    /// </summary>
    public partial class Дома_Подробно_Редакт : Page
    {
        public Дома_Подробно_Редакт()
        {
            InitializeComponent();
            cmbComplex.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().ResidentialComplexes.ToList();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string
                param1 = cmbComplex.Text,
                param2 = txtStreet.Text,
                param3 = txtNum.Text;
            decimal
                param4 = decimal.Parse(txtBuildCost.Text);
             int  param5 = int.Parse(txtCost.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().InsertHome(cmbComplex.SelectedIndex,param2,param3,param4,param5);
        }
    }
}
