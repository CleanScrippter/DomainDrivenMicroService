using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Service;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGetProduct _productformation;

        public ProductController(IGetProduct productformation)
        {
            _productformation = productformation;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<ActionResult> Get(string productname)
        {
            try
            {

                _productformation.GetActiveProducts(productname); 
                return new CreatedResult(string.Empty, new { Code = 200, Status = true, Message = "", Products = "" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }
    }
}
