using ProductApi.Data.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Data.Repository.v1
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly ProductContext ProductContext;
        public Repository(ProductContext productContext)
        {
            ProductContext = productContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                await ProductContext.AddAsync(entity);
                await ProductContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} eklenemedi: {ex.Message}");
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return ProductContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"hata: {ex.Message}");
            }

        }
    }
}
