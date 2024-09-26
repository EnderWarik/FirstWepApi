namespace TestProjectTZ
{
    public interface Repository
    {
        string Create(string name, int price);
        string Delete(int id);
        List<Product> FindAll();
        List<Product> FindByID(int ID);
        string Update(int ID, string name, int price);
    }
}
