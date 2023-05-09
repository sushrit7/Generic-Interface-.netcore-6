using APIRepositoryInterface.Interface;
using APIRepositoryInterface.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIRepositoryInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericController<Employee> 
    {
        public EmployeeController(IGenericService<Employee> genericService): base(genericService)
        {
            
        }


    }
}
