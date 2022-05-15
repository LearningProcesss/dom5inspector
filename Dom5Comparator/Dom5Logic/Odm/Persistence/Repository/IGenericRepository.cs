using Dom5Logic.Odm.Persistence.Models;

namespace Dom5Logic.Odm.Persistence.Repository;

public interface IGenericRepository<T> where T : IModel
{
    IEnumerable<T> Get();
    T? GetById(int id);
}