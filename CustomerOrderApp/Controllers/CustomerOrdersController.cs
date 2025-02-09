using CustomerOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CustomerOrderApp.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // GET: CustomerOrders
        public ActionResult Index()
        {
            // Örnek bir müşteri oluştur
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // Örnek siparişler oluştur
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 1200.00m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 25.00m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Keyboard", Price = 50.00m, Quantity = 1 }
            };

            // ViewModel'i oluştur
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // ViewModel'i view'a ilet
            return View(viewModel);
        }
    }
}