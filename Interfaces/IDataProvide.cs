namespace HW_M6L1
{
    public interface IDataProvide
    {
        void Create(Product product);
        Product Select(int id);
        void Update(Product product);
        void Delete(int id);
    }
}
