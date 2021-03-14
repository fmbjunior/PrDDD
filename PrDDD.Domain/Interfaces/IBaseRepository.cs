using PrDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrDDD.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        Task InsertAsync(TEntity obj);
        Task InsertAsync(IEnumerable<TEntity> obj);

        void Update(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task UpdateAsync(IEnumerable<TEntity> obj);

        void Delete(TEntity obj);
        Task DeleteAsync(TEntity obj);
        Task DeleteAsync(IEnumerable<TEntity> obj);
    }
}
