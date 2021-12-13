using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectTZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        Service service = new Service();
        // GET: api/<MainController>
        [HttpGet]
        public List<Product> Get()
        {
            return service.GET();

        }

        // GET api/<MainController>/5
        [HttpGet("{id}")]
        public List<Product> GetbyID(int id)
        {
            return service.GETbyID(id);
        }

        // POST api/<MainController>
        [HttpPost]
        public string Post([FromBody] Product product) //FFFFFFFFFFFFFFFFFFF
        {

            return service.POST(product.Name, product.Price);
            
        }

        // PUT api/<MainController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Product product)
        {
            return service.PUT(id,product.Name, product.Price);
        }

        // DELETE api/<MainController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return service.DELETE(id);
        }
    }
}
