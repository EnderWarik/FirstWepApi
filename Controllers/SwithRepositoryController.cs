using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectTZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwithRepositoryController : Controller
    {
        Service service = new Service(new RepositoryHight());
        // GET: api/<SwitchController>
        [HttpGet]
        public List<Product> FindAll()
        { 
            return service.FindAll();

        }

        // GET api/<MainController>/5
        [HttpGet("{id}")]
        public List<Product> FindbyID(int id)
        {
            return service.FindbyID(id);
        }

        // POST api/<MainController>
        [HttpPost]
        public string Create([FromBody] Product product) 
        {
            service.Create(product.Name, product.Price);
            
            //вытаскиваю имя , проверяю нал или нет, и если нал выводить об ошибке.
            return service.Create(product.Name, product.Price);
            
        }

        // PUT api/<MainController>/5
        [HttpPut("{id}")]
        public string Update(int id, [FromBody] Product product)
        {
            return service.Update(id,product.Name, product.Price);
        }

        // DELETE api/<MainController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
