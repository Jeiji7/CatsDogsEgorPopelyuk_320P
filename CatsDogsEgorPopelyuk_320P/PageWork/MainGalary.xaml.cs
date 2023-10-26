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
    /// Логика взаимодействия для MainGalary.xaml
    /// </summary>
    public partial class MainGalary : Page
    {
        public MainGalary()
        {
            InitializeComponent();
        }

        private void SearchTBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
