using APIRepositoryInterface.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIRepositoryInterface.Controllers
{
    public class GenericController<T> : Controller where T : class
    {

        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }

        
        [HttpDelete ("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }

        
    }
}
