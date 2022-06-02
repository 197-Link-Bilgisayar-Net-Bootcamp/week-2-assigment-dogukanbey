using Microsoft.AspNetCore.Mvc;
using ddiraganEFdotnetCoreApi.Models;
using ddiraganEFdotnetCoreApi.Repository;


namespace ddiraganEFdotnetCoreApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
    
        LinkContext _linkContext;
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("");

        }


        [HttpGet("{name}")]
        public IActionResult GetByName(string nameLike)
        {

            return Ok($"{nameLike}");
        }






        //riskli veri Frombodyde
        [HttpPost]
        public IActionResult Add(Product product)
        {
            return Ok("Added");
        }





        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Updated");
        }




        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
        _linkContext.Products.Remove

            return Ok("Deleted");
        }






    }

}
