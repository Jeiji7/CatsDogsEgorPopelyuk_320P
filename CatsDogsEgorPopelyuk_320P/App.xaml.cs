﻿using CatsDogsEgorPopelyuk_320P.DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CatsDogsEgorPopelyuk_320P
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CatsDogsBaseEntities BD = new CatsDogsBaseEntities();
    }
}
