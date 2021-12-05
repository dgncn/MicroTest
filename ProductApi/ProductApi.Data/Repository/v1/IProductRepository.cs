using ProductApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApi.Data.Repository.v1
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductById(Guid id,CancellationToken cancellationToken);
    }
}
