
namespace Infrastructure.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> GetById(Guid id);

    Task<T> Create(T entity);

    Task<T> Update(T entity);

    Task<T> Delete(Guid id);


}
