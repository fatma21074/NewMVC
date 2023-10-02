using Microsoft.AspNetCore.Mvc;
using NewMVC.Data;
using NewMVC.Models.Dto;

namespace NewMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(OrderDto order)
        {
            if (!ModelState.IsValid)
                return View(order);
            var Order = new Models.Order
            {
                ProductId = order.ProductId,
              
                DateTime = DateTime.Now,
            };
            _context.orders.Add(Order);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Index(OrderDto dtos)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == 2);
           ;
            var Order = new UserOrderDto
            {
                
                Price = product.Price,
                Name = product.Name,
                Description = product.Description,
                ProductId = product.Id,

            };
            return View(Order);
        }
    }
}
