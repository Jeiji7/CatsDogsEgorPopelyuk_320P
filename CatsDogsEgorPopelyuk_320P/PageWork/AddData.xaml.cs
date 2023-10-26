using CatsDogsEgorPopelyuk_320P.DataBase;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            var typee = App.BD.AnimalType.ToList();
            TypeAnimalCB.ItemsSource = typee.ToList();
            TypeAnimalCB.DisplayMemberPath = "Name_animal";
        }

        private void AddDataBT_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Animal animals = new Animal()
                {
                    Exposition = ExpositionsTB.Text.Trim(),
                    ID_animal_type = (TypeAnimalCB.SelectedItem as AnimalType).ID_animal_type,
                    ID_users = (TypeAnimalCB.SelectedItem as AnimalType).ID_animal_type
                };
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
                };
                if (openFileDialog.ShowDialog().GetValueOrDefault())
                {
                    animals.Image_animal = File.ReadAllBytes(openFileDialog.FileName);
                    AddImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));

                    App.BD.Animal.Add(animals);
                    App.BD.SaveChanges();
                }
            }
            catch 
            {
                MessageBox.Show("А ну ка всё заполнил `_`");
            }   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageWork.MainGalary());
        }
    }
}
