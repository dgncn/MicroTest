using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Data.Repository.v1
{
    public interface IRepository<TEntity> where TEntity : class,new()
    {
        IEnumerable<TEntity> GetAll();
        Task<TEntity> AddAsync(TEntity entity);
    }
}
