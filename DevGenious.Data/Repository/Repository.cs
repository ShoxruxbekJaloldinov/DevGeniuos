﻿using DevGenious.Data.IRepositories;
using DevGenious.Domain.Commons;
using DevGenious.Domain.Configurations;
using DevGenious.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGenious.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly string Path = "";
        public Repository() 
        {
            if(typeof(User) == typeof(TEntity))
            {
                Path = DatabasePath.UserDb;
            }
            else
            {
                Path = DatabasePath.SubjectDb;
            }

        }
        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SelectByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
