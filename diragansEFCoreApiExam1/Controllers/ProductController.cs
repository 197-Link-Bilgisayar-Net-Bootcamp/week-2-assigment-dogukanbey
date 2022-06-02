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
     
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAllProduct());
        }


        [HttpGet("{id}")]  
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetProductByID(id));
        }




        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok(product);
        }


      


        [HttpPut]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return Ok(product);
        }




        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok($"Deleted ID:{id}");
        }









    }
}
