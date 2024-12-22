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

namespace Automehanik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void singMaster_Click(object sender, RoutedEventArgs e)
        {
            {
                string username = login.Text;
                string password = pass.Password;

                if (username == "Master" && password == "123")
                {
                    FrmMain.Navigate(new Pages.Master());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");

                }
            }
        }

        private void singMehanik_Click(object sender, RoutedEventArgs e)
        {
            string username = login.Text;
            string password = pass.Password;

            if (username == "Mehanik" && password == "1234")
            {
                FrmMain.Navigate(new Pages.Mehanik());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void sing_Click(object sender, RoutedEventArgs e)
        {
            string username = login.Text;
            string password = pass.Password;

            if (username == "Diagnost" && password == "12345")
            {
                FrmMain.Navigate(new Pages.Diagnost());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}