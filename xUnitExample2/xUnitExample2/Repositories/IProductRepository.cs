using xUnitExample2.Entities;

namespace xUnitExample2.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
    }
}
