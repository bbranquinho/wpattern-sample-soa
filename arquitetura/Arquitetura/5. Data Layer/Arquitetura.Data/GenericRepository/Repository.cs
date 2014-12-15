using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;
using Arquitetura.Data.DataContext;
using Arquitetura.Data.GenericRepositoryInterfaces;

namespace Arquitetura.Data.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Properties
        protected ObjectContext Context { get; set; }

        protected IObjectSet<T> ObjectSet { get; set; }
        #endregion

        #region Constructors
        public Repository() : this(new NorthwindEntities())
        {
        }

        public Repository(ObjectContext context)
        {
            Context = context;
            ObjectSet = Context.CreateObjectSet<T>();
        }
        #endregion

        #region CrudMethods
        public IQueryable<T> GetQuery()
        {
            return ObjectSet;
        }

        public IEnumerable<T> GetAll()
        {
            return ObjectSet.AsEnumerable();
        }

        public IEnumerable<T> Find(Func<T, bool> where)
        {
            return ObjectSet.Where(where);
        }

        public T Single(Func<T, bool> where)
        {
            return ObjectSet.Single(where);
        }

        public T First(Func<T, bool> where)
        {
            return ObjectSet.First(where);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity");
            }

            var entityKey = Context.CreateEntityKey(EntitySetDictionary.GetEntityKey(entity), entity);

            Object attachedObject = new Object();

            if (Context.TryGetObjectByKey(entityKey, out attachedObject))
            {
                Context.DeleteObject(attachedObject);
            }
            else
            {
                throw new ObjectNotFoundException();
            }

            SaveChanges();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            if (entity is IValidator)
            {
                ((IValidator) entity).Validate();
            }

            ObjectSet.AddObject(entity);
            
            SaveChanges();
        }

        public void Attach(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            if (entity is IValidator)
            {
                ((IValidator)entity).Validate();
            }

            ObjectSet.Attach(entity);
        }

        public void Update(T entity)
        {
            var entityKey = Context.CreateEntityKey(EntitySetDictionary.GetEntityKey(entity), entity);

            Object attachedObject = new Object();

            if (Context.TryGetObjectByKey(entityKey, out attachedObject))
            {
                Context.ApplyCurrentValues(entityKey.EntitySetName, entity);
            }
            else
            {
                throw new ObjectNotFoundException();
            }

            SaveChanges();
        }
        #endregion

        #region SaveChanges
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void SaveChanges(SaveOptions saveOptions)
        {
            Context.SaveChanges(saveOptions);
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                    Context = null;
                }
            }
        }
        #endregion
    }
}
