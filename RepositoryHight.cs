using Microsoft.EntityFrameworkCore;
namespace TestProjectTZ
{
    public class RepositoryHight : DbContext,Repository
    {
        public DbSet<Product> product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=EnderWarAdmin;database=firstdb;",
                new MySqlServerVersion(new Version(8, 0, 27))
            );
        }

        public string Create(string name, int price)
        {
            if (name != null && !name.StartsWith(" "))  //я не гей
            {
                Product product1 = new Product { Name = name, Price = price };
                product.Add(product1);
                SaveChanges();
                return "exelent1";
            }
            else
            {
                return "error";
            }


        }
        public string Delete(int id)
        {
            Product product1 = new Product { ID = id };
            product.Remove(product1);
            SaveChanges();
            return "exelent";
        }
        public List<Product> FindAll()
        {
            var products = product.ToList();
            return products;
            //List<Product> listProduct = new List<Product>();

            //    var products = product.ToList();
            //    foreach (var u in products)
            //    {
            //    listProduct.Add(new Product {ID=u.ID, Name = u.Name, Price = u.Price });
            //}
            
            //return listProduct;
        }
        public List<Product> FindByID(int ID)//проверить на несуществующий айди yt kbcn
        {
            var product1 = product.FirstOrDefault(x => x.ID == ID);
            //Product product1 = product.Find(ID=ID);
             List<Product> listProduct = new List<Product>();
            listProduct.Add(product1);

            // }
            return listProduct;
        }

        public string Update(int ID, string name, int price)
        {
            Product product1 = product.FirstOrDefault(x => x.ID==ID);
            product1.Name = name;
            product1.Price = price;
            SaveChanges();
            
            return "exelent";
        }
    }
}

