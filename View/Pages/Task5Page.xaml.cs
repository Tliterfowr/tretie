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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(TbA.Text) % 2 == 1 && Convert.ToDouble(TbB.Text) % 2 == 1)
                {
                    MessageBox.Show($"True");
                }
                else
                {
                    MessageBox.Show($"False");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }

        private void TbB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TbA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
