using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Data;
using ApiTest.Models;
using ApiTest.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var order = await _productService.GetProduct(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

         // POST api/<ProductsController>
        //[HttpPost]
        //public async Task<ActionResult<Product>> Post([FromBody] Product product)
        //{
        //    _context.Products.Add(product);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProductExists(product.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("Get", new { id = product.Id }, product);
        //}

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] Product product)
        //{
        //     if (id != product.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}
       
        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var product = await _context.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Products.Remove(product);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProductExists(int id)
        //{
        //    return _context.Products.Any(p => p.Id == id);
        //}
    }
}
