using System.Threading.Tasks;
using Study02.Infrastructure.Data.Repositories.Interfaces;

namespace Study02.Infrastructure.Data.Repositories
{
    public class DatabaseRepository : RepositoryBase, IDatabaseRepository
    {
        public DatabaseRepository(ISqLiteConnection sqLiteConnection) : base(sqLiteConnection)
        {
        }

        public Task CreateDatabaseAsync()
        {
            return Database.CreateTablesAsync(typeof());
        }
    }
}
