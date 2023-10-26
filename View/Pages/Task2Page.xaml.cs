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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
            bool x = false;
            bool y = true;
            bool z = false;
            TbTask1.Text = $"{x && !(z || y) || !z}";
            TbTask2.Text = $"{!x || x && (x || z)}";
            TbTask3.Text = $"{(x || y && !z) && z}";
        }
       
    }
}
