using xUnitExample2.Repositories;

namespace xUnitExample2.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo) => _repo = repo;

        public decimal GetPriceWithTax(int productId)
        {
            var product = _repo.GetById(productId);
            if (product == null) throw new ArgumentException("Invalid product");
            return product.Price * 1.2m; // add 20% tax
        }
    }
}
