namespace PensionWorld.Domain.Repositories
{
    using System.Linq;

    public interface IBaseRepository<T, in TId>
    {
        IQueryable<T> GetAll();

        T GetById(TId id);

        void Save(T entity, TId id);
    }
}