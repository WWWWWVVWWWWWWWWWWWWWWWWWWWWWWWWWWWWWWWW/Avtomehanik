using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automehanik.ApplicationData
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
