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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
            double x = 1;
            double y = 2;
            TbTask1.Text = $"{(!(x * y < 0)) || (y > x)}";
            double x1 = 2;
            double y1 = 1;
            TbTask2.Text = $"{(x1 * y1 != 0) && (y1 < x1)}";
        }
    }
}
