﻿using System;
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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
            bool a = true;
            bool b = false;
            bool c = false;
            TbTask1.Text = $"{(a || !a && b) || c}";
            TbTask2.Text = $"{!a || a && (b || c)}";
            TbTask3.Text = $"{(a || b && !c) && c}";
        }

       
    }
}
