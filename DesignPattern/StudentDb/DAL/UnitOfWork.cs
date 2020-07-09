using StudentDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDb.DAL
{
    public class UnitOfWork : IDisposable
    {
        private StudentDbContext _DbContext = new StudentDbContext();

        public GenericRepository<TEntityType> GetRepositoryInstance<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(_DbContext);
        }
        public void SaveChanges()
        {
            _DbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }

}
/*
 * 
 */