using System.Threading.Tasks;
using CreditApp02.Infrastructure.Data;
using CreditApp02.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp02.Core.UWP
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly IDatabaseRepository _databaseRepository;

        public DatabaseManager(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public async Task ConfigureAsync()
        {
          await  _databaseRepository.CreateDatabaseAsync().ConfigureAwait(false);
        }
    }
}
