using System.Windows;
using WpfApp3.Core;
using WpfApp3.View.Pages;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainNavigateCoreFrame.MyFrame = MainFrame;
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task1Page());
        }
       
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task2Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task3Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task5Page());
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task6Page());
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task7Page());
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task8Page());
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task9Page());
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task10Page());
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task11Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            MainNavigateCoreFrame.MyFrame.Navigate(new Task4Page());
        }
    }
}
