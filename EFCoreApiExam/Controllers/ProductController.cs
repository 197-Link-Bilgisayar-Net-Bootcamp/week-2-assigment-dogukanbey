using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using diragansEFCoreApiExam1.Models;
using diragansEFCoreApiExam1.Repository;

namespace diragansEFCoreApiExam1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        //Get all products
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_productRepository.GetAllProduct());
            }
            catch { return NotFound(); }
        }


        //Get 1 product by id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_productRepository.GetProductByID(id));
            }
            catch { return NotFound(); }
        }



        //Insert a new product record
        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            try
            {
                _productRepository.AddProduct(product);
                return Ok();
            }
            catch { return BadRequest(); }
        }




        //Edit a product 
        [HttpPut]
        public IActionResult Update(Product product)
        {
            try
            {
                _productRepository.UpdateProduct(product);
                return Ok(product);
            }
            catch { return BadRequest(); }
        }



        //Delete a product by ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productRepository.DeleteProduct(id);
                return Ok($"Deleted ID:{id}");
            }
            catch { return BadRequest(); }
        }



    }
}