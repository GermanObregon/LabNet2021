
using System.Data.Entity;

using Tp4.AccesData.Command.Repository;

namespace Tp4.AccesData.Command
{
    public class GenericRepository : IGenericRepository
    {
        private readonly NorthwindContext Contexto;

        public GenericRepository()
        {
            this.Contexto = new NorthwindContext();
        }
        public void Add<T>(T entity) where T : class
        {
            using (Contexto)
            {
                var dbSet = Contexto.Set<T>();
                dbSet.Add(entity);
                Contexto.SaveChanges();
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            using (Contexto)
            {
                
                var dbSet = Contexto.Set<T>();
                dbSet.Attach(entity);
                Contexto.Entry(entity).State = EntityState.Deleted;
                Contexto.SaveChanges();

            }
        }

        public void Update<T>(T entity) where T : class
        {
            using (Contexto)
            {

                var dbSet = Contexto.Set<T>();
                dbSet.Attach(entity);
                Contexto.Entry(entity).State = EntityState.Modified;
                Contexto.SaveChanges();

            }
        }
    }
}
