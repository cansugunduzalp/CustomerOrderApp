using System.Collections.Generic;

namespace CustomerOrderApp.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}