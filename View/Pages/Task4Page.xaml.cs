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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
           
        }

        private void TbA_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (Convert.ToDouble(TbA.Text) % 2 == 0 || Convert.ToDouble(TbA.Text) % 3 == 0)
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
    }
}
