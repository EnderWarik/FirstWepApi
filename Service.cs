namespace TestProjectTZ
{
    public class Service : Repository
    {

        public string POST(string name, int price)
        {
            return Create(name,price);
        }

        public string DELETE( int id)
        {
            return Delete(id);
        }
         
        public List<Product> GET(){
            List<Product> products = FindAll();
           return products;
    }

        public List<Product> GETbyID(int id)
        {
            List<Product> products = FindByID(id);
            return products;
        }
        public string PUT(int id,string name, int price)
        {
            return Update(id,name,price);
        }
        
    }
}
