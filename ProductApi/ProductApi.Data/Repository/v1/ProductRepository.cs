using Microsoft.EntityFrameworkCore;
using ProductApi.Data.Database;
using ProductApi.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApi.Data.Repository.v1
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext productContext) : base(productContext)
        {

        }
        public async Task<Product> GetProductById(Guid id, CancellationToken cancellationToken)
        {
            return await ProductContext.Product.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
