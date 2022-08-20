using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
            new Product{Id= 1, Name = "Apple", Category = "Fruit", Price = 30, Quantity = 100},
            new Product{Id= 2, Name = "Banana", Category = "Fruit", Price = 10, Quantity = 80},
            new Product{Id= 3, Name = "Tomato", Category = "Vegetable", Price = 15, Quantity = 60},
            new Product{Id= 4, Name = "Taro", Category = "Fish", Price = 90, Quantity = 25},
            new Product{Id= 5, Name = "Egg", Category = "egg", Price = 5, Quantity = 250},
            new Product{Id= 6, Name = "Beef", Category = "Fresh", Price = 135, Quantity = 60},
            new Product{Id= 7, Name = "Pork", Category = "Fresh", Price = 100, Quantity = 90}
        };

        public IEnumerable<Product> GetAllProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
