using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectTZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HightController : Controller
    {
       

        // GET: api/<SwitchController>
        [HttpGet]
        public List<Product> FindAll()
        {
            using (Connection db = new Connection())
                return  db.product.ToList();
        }

        // GET api/<MainController>/5
        [HttpGet("{id}")]
        public List<Product> FindbyID(int id)
        {
            Product product2 = new Product();
            using (Connection db = new Connection())
                product2 = db.product.ToList().FirstOrDefault(x => x.ID == id);

            List<Product> listProduct = new List<Product>();
            listProduct.Add(product2);

            Console.WriteLine(product2.Name);
            return listProduct;
        }

        // POST api/<MainController>
        [HttpPost]
        public Product Create([FromBody] Product product)
        {
            using (Connection db = new Connection())
            {
                //вытаскиваю имя , проверяю нал или нет, и если нал выводить об ошибке.
                //Product product1 = new Product { Name = name, Price = price };
                db.product.Add(product);
                db.SaveChanges();
                return product;
            }

        }

        // PUT api/<MainController>/5
        [HttpPut("{id}")]
        public Product Update(int id,[FromBody] Product product)
        {
            using (Connection db = new Connection())
            {
                var product1 = db.product.FirstOrDefault(x => x.ID == id);
                product1.Name = product.Name;
                product1.Price = product.Price;
                db.SaveChanges();
                return product1;
            }
        }

        // DELETE api/<MainController>/5
        [HttpDelete("{id}")]
        public Product Delete(int id)
        {
            using (Connection db = new Connection())
            {
                var product = db.product.Where(o => o.ID == id).FirstOrDefault();
                db.product.Remove(product);
                db.SaveChanges();
                return product;
            }
        }
    }
}
