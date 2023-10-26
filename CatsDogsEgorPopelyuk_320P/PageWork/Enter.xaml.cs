using CatsDogsEgorPopelyuk_320P.DataBase;
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

namespace CatsDogsEgorPopelyuk_320P.PageWork
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Page
    {
        public static List<Users> Users { get; set; }
        public Enter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordPB.Password.Trim();
            Users = new List<Users>(App.BD.Users.ToList());
            Users currentUser = Users.FirstOrDefault(x => x.Name == login && x.Password == password);
            if (currentUser != null)
                NavigationService.Navigate(new PageWork.AddData());
            else
                MessageBox.Show("Данные не верны");
        }
    }
}
