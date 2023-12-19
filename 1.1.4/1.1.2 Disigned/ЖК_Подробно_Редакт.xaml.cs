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
    /// Логика взаимодействия для ЖК_Подробно_Редакт.xaml
    /// </summary>
    public partial class ЖК_Подробно_Редакт : Page
    {
        public ЖК_Подробно_Редакт()
        {
            InitializeComponent();
            string conection = "data source=1-510-CLS-04;initial catalog=БИЗЬНЕСь_ИР311;persist security info=True;user id=sa;password=123";
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string
                param1 = txtName.Text,
                param2 = txtCity.Text,
                param3 = cmbStatus.Text;
            decimal
                param4 = decimal.Parse(txtCostBuild.Text);
            int  param5 = int.Parse(txtCost.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().InsertResident(param1, param2, param3, param4, param5);
        }
    }
}
