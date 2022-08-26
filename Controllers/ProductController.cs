namespace HW_M6L1;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    // GET
    [HttpGet("{id}")]
    public Product Get([FromRoute] int id)
    {
        return _productService.Get(id);
    }

    // POST
    [HttpPost]
    public void Post([FromBody] ProductModel product)
    {
        _productService.Create(new Product(product.Name, product.Price));
    }

    // PUT
    [HttpPut]
    public void Update([FromBody] ProductModel product)
    {
        _productService.Update(new Product(product.Name, product.Price));
    }

    // DELETE
    [HttpDelete("{id}")]
    public void Delete([FromRoute] int id)
    {
        _productService.Delete(id);
    }
}
