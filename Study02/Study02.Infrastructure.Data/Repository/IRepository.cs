﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Study02.Infrastructure.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetOne(string id);
        Task AddOne(T t);
        Task<DeleteResult> DeleteOne(string id);
        Task<DeleteResult> DeleteMany(string foreignId);
        Task<ReplaceOneResult> Update(T t);
    }
}
