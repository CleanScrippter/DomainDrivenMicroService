using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts.Model;
using Contracts.Service;
namespace ContractManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGetContracts _contractinformation;

        public ValuesController(IGetContracts contractinformation)
        {
            _contractinformation = contractinformation;
        }

        [HttpGet(Name = "GetContracts")]
        public async Task<ActionResult> Get(int countryId)
        {
            try
            {
                
                var employeeList =  _contractinformation.GetActiveContracts(countryId); ;
                return new CreatedResult(string.Empty, new { Code = 200, Status = true, Message = "", Contracts = employeeList });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            

        }

        //[HttpGet(Name = "CreateContracts")]
        //public async Task<ActionResult> Post(int countryId)
        //{
        //    try
        //    {
        //        var employeeList = _contractinformation.GetActiveContracts(countryId); ;
        //        return new CreatedResult(string.Empty, new { Code = 200, Status = true, Message = "", Contracts = employeeList });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }


        //}
    }
}
