﻿using CatsDogsEgorPopelyuk_320P.DataBase;
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
            PhotoGalaryList.ItemsSource = App.BD.Animal.ToList();


        }

        private void SearchTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            PhotoGalaryList.ItemsSource = new List<Animal>(App.BD.Animal.Where(i => i.Exposition.StartsWith(SearchTBox.Text)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
