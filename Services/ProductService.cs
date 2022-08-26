namespace HW_M6L1
{
    public class ProductService : IProductService
    {
        private IDataProvide _dataProvider;

        public ProductService(IDataProvide dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Create(Product product)
        {
            _dataProvider.Create(product);
        }

        public Product Get(int id)
        {
            return _dataProvider.Select(id);
        }

        public void Update(Product product)
        {
            _dataProvider.Update(product);
        }

        public void Delete(int id)
        {
            var product = _dataProvider.Select(id);
            if (product != null)
            {
                _dataProvider.Delete(id);
            }
        }
    }
}
