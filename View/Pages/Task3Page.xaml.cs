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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
            double x = 2;
            double y = 1;
            TbTask1.Text = $"{(!(x * y < 0)) && (y > x)}";
            double x1 = 2;
            double y1 = -2;
            TbTask2.Text = $"{(x1 >= 2) || (Math.Pow(y1, 2) != 5)}";
        }
    }
}
