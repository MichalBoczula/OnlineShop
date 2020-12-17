using OnlineShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure.Repositories
{
    public class MobilePhoneRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseContext _databaseContext;

        public MobilePhoneRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
