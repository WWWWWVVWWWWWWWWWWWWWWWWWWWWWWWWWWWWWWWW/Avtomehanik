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
using Automehanik.ApplicationData;

namespace Automehanik.Pages
{
    /// <summary>
    /// Логика взаимодействия для Diagnost.xaml
    /// </summary>
    public partial class Diagnost : Page
    {
        public Diagnost()
        {
            InitializeComponent();
            LoadOrders();
        }
        private void LoadOrders()
        {
            var orders = new List<Order>
            {
                new Order { Id = 1, ClientName = "Bанов И..", Status = "Пpинят", Date = DateTime.Now },
                new Order { Id = 2, ClientName = "Пeтpoв П..", Status = "В пpoцecce", Date = DateTime.Now  }
            };

            OrdersDataGrid.ItemsSource = orders;

        }

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersDataGrid.SelectedItem is Order selectedOrder)
            {
                selectedOrder.Status = "Оплачен";
                OrdersDataGrid.Items.Refresh();
                MessageBox.Show("Статус заказа изменен", "Успех", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Выберите заказ для изменения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            var createOrderWindow = new Diagnost();
            createOrderWindow.OrderCreated += (s, order) =>
            {
                orders.Add(new order);
                OrdersDataGrid.Items.Refresh();

            };
            createOrderWindow.ShowDialog();
        }
    }
    }
