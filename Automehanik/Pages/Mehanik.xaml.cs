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

namespace Automehanik.Pages
{
    /// <summary>
    /// Логика взаимодействия для Mehanik.xaml
    /// </summary>
    public partial class Mehanik : Page
    {
        internal Action<object, object> OrderCreated;

        public Mehanik()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var newOrder = new Order
            {
                Id = 3,
                ClientName = "Новый клиент",
                Status = "Принят",
                Date = DateTime.Now
            };

        }
        private int GetNextOrderId()
        {
            return 3;
        }
    }
}
