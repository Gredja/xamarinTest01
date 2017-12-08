using System.Threading.Tasks;
using CreditApp02.Infrastructure.Data.Repositories.Interfaces;
using SQLite;

namespace CreditApp02.Infrastructure.Data.Repositories
{
    public class DatabaseRepository : BaseRepository, IDatabaseRepository
    {
        public DatabaseRepository(ISqLiteConnection sqLiteConnection) : base(sqLiteConnection) { }

        public Task CreateDatabaseAsync()
        {
            return Database.CreateTablesAsync(CreateFlags.None, typeof(Dto.Debtor));
        }
    }
}