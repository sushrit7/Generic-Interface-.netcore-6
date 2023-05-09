using APIRepositoryInterface.Interface;
using APIRepositoryInterface.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIRepositoryInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : GenericController<Employer>
    {
        public EmployerController( IGenericService<Employer> genericService) : base(genericService)
        {
            
        }
    }
}
