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
    /// Логика взаимодействия для Квартиры_Подробно_Редакт.xaml
    /// </summary>
    public partial class Квартиры_Подробно_Редакт : Page
    {
        public Квартиры_Подробно_Редакт()
        {
            InitializeComponent();
            cmbHouse.ItemsSource = БИЗЬНЕСь_ИР311Entities.GetContext().Houses.ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int param1 = Convert.ToInt32(txtNum.Text),
                param4 = Convert.ToInt32(txtRoomNum.Text),
                param5 = Convert.ToInt32(txtPadik.Text),
                param6 = Convert.ToInt32(txtFloor.Text),
                param7 = Convert.ToInt32(txtBuildCost.Text),
                param8 = Convert.ToInt32(txtCost.Text);
            decimal param2 = Convert.ToDecimal(txtV.Text);
            БИЗЬНЕСь_ИР311Entities.GetContext().InsertApar(cmbHouse.SelectedIndex, param1, param2, param4,param5, param6, cmbStatus.SelectedIndex, param7, param8);
        }
    }
}
