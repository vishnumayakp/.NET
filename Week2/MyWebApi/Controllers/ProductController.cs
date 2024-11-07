using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyWebApi.Models;
using Microsoft.AspNetCore.Http.Features;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product {Id=1,Name="Laptopwhhjhjjlklldsdsasdsad",Price=59000},
            new Product {Id=2,Name="Keyboard",Price=2000},
            new Product {Id=3,Name="Mouse",Price=900}

        };

        [HttpGet]

        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(products => products.Id == id);
                if (product == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(product);
                }
            
        }

        [HttpPost]

        public ActionResult<Product> CreateProduct(Product newProduct)
        {
            newProduct.Id = products.Max(i=>i.Id)+1;
            products.Add(newProduct);
            return CreatedAtAction(nameof(GetProducts), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateItem(int id ,Product updatedproduct)
        {
            var existingProduct = products.FirstOrDefault(i => i.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = updatedproduct.Name;
            return NoContent();
        }


    }
}
