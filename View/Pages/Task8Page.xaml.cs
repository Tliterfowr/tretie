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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
            double x = 1;
            double y = 2;
            TbTask1.Text = $"{(x >= 0) && (Math.Pow(y,2) != 4)}";
            double x1 = 2;
            double y1 = 1;
            TbTask2.Text = $"{(x1 * y1 != 0) || (y < x)}";
        }
    }
}
