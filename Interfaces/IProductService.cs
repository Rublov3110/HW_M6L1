namespace HW_M6L1
{
    public interface IProductService
    {
        void Create(Product product);
        Product Get(int id);
        void Update(Product product);
        void Delete(int id);
    }
}
