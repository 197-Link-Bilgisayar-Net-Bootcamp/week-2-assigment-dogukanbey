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
     
        private readonly IProductRepository _productService;
        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }


        //Get all products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAllProduct());
        }


        //Get 1 product by id
        [HttpGet("{id}")]  
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetProductByID(id));
        }



        //Insert a new product record
        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok(product);
        }


      

        //Edit a product 
        [HttpPut]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return Ok(product);
        }



        //Delete a product by ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok($"Deleted ID:{id}");
        }


    }
}
