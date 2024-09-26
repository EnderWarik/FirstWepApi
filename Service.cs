namespace TestProjectTZ
{
    public class Service
    {
        Repository repository;
        public Service(Repository repository) { this.repository = repository; }
        public string Create(string name, int price)
        {
            return repository.Create(name,price);   
        }

        public string Delete( int id)
        {
            return repository.Delete(id);
        }
         
        public List<Product> FindAll(){
            List<Product> products = repository.FindAll();
           return products;
    }

        public List<Product> FindbyID(int id)
        {
            List<Product> products = repository.FindByID(id);
            return products;
        }
        public string Update(int id,string name, int price)
        {

            return repository.Update(id,name,price);
        }
        
    }
}
