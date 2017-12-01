using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Study02.Infrastructure.Data.Model.Base;

namespace Study02.Infrastructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly MongoDbContex<T> _context;

        public Repository(IOptions<Settings> settings)
        {
            _context = new MongoDbContex<T>(settings);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await IMongoCollectionExtensions.Find(_context.Collection, _ => true).ToListAsync();
        }

        public async Task<T> GetOne(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return await IMongoCollectionExtensions.Find(_context.Collection, filter).FirstAsync();
        }

        public async Task AddOne(T t)
        {
            await _context.Collection.InsertOneAsync(t);
        }

        public async Task<DeleteResult> DeleteOne(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return await _context.Collection.DeleteOneAsync(filter);
        }

        public async Task<DeleteResult> DeleteMany(string foreignId)
        {
            var filter = Builders<T>.Filter.Eq("ForeignId", foreignId);
            return await _context.Collection.DeleteManyAsync(filter);
        }

        public async Task<ReplaceOneResult> Update(T t)
        {
            var filter = Builders<T>.Filter.Eq("Id", t.Id);
            return await _context.Collection.ReplaceOneAsync(filter, t);
        }
    }
}
