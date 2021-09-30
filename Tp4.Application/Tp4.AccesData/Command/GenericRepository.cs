
using System.Data.Entity;
using System;

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
            try
            {
                using (Contexto)
                {
                    var dbSet = Contexto.Set<T>();
                    dbSet.Add(entity);
                    Contexto.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un Problema para agregar a la base de datos");
            }
            
        }

        public void Delete<T>(int id) where T : class
        {
            try
            {
                using (Contexto)
                {
                    var dbSet = Contexto.Set<T>();
                    dbSet.Remove(dbSet.Find(id));
                           
                    Contexto.SaveChanges();

                }

            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un Problema al borrar de la base de datos");
            }
            
        }

        public void Update<T>(T entity) where T : class
        {
            try
            {
                using (Contexto)
                {

                    var dbSet = Contexto.Set<T>();
                    dbSet.Attach(entity);
                    Contexto.Entry(entity).State = EntityState.Modified;
                    Contexto.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un porblema al editar en la base de datos");
            }
           
        }
    }
}
