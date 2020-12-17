using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Infrastructure.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseContext databaseContext;  
        private DbSet<T> dbSet;

        public BaseRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }
       
        public void Update(T obj)
        {
            databaseContext.Entry(obj).State = EntityState.Modified;
        }
       
        public void Delete(int id)
        {
            T getObjById = dbSet.Find(id);
            dbSet.Remove(getObjById);
        }

        public void Save()
        {
            databaseContext.SaveChanges();
        }
    }
}
