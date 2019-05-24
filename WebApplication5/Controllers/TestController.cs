using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Interfaces;
using WebApplication5.Models;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IProductRepository _repository { get; set; }
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        //[HttpGet("[action]")]
        //public Task<IEnumerable<Product>> ProductForecasts()
        //{
        //    return _repository.GetAll();
        //}
        [HttpGet("[action]")]
        public IEnumerable<Product> ProductForecasts()
        {
            return _repository.GetAll();
        }

        // GET: api/<controller>
        //[HttpGet]
        //public Task<IEnumerable<Product>> Get()
        //{
        //    // return new string[] { "value1", "value2" };
        //    return _repository.GetAll();
        //}
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            // return new string[] { "value1", "value2" };
            return _repository.GetAll();
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        //

        public Product Get(int id)
        {
            var product = _repository.GetById(id);
            var product3 = _repository.GetById(3);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //return Ok(product);
            return product3;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
