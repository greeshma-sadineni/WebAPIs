using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> products = new List<Product>()
        {
             new Product {
            Id=100578,
            Name="Austin and Barbeque AABQ WIFI Food Thermometer",
            Description="Termometer med wifi for en optimal innertemparature",
            Price=399
            },
             new Product {
            Id=1009334,
            Name="Anderson  Electrisk Tandare Ecl1.1",
            Description="Electric stormasker tandare helt utan gas och bransle",
            Price=299
            },
              new Product {
            Id=100987,
            Name="Webber NonSticky Spray",
            Description="BBQ-oljspray som motverkar att ravaror fasten pa gallret",
            Price=99
            },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }
        //Add New Product
        [HttpPost]
        public ActionResult Post([FromBody]Product product)
        {
            if (products.Exists(p => p.Id == product.Id))
            {
                return Conflict();
            }
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, products);
        }

        //Delete the Product
        [HttpDelete("{Id}")]
        public ActionResult<IEnumerable<Product>> Delete(int id)
        {
            var product = products.Where(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products = products.Except(product).ToList();
            return products;
        }
        //Update Product
        [HttpPut("{Id}")]
        public ActionResult<IEnumerable<Product>> Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var existingProduct = products.Where(p => p.Id == id);
            products = products.Except(existingProduct).ToList();
            products.Add(product);
            return products;
        }

    }
}