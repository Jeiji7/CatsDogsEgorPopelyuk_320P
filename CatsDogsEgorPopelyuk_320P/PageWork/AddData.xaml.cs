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

namespace CatsDogsEgorPopelyuk_320P.PageWork
{
    /// <summary>
    /// Логика взаимодействия для AddData.xaml
    /// </summary>
    public partial class AddData : Page
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void AddDataBT_Click(object sender, RoutedEventArgs e)
        {
            try 
            {

            }
            catch 
            {
                MessageBox.Show("А ну ка всё заполнил `_`");
            }   
        }
    }
}
