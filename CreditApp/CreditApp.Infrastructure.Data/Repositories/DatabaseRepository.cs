
using CreditApp.Infrastructure.Data.Repositories.Base;
using CreditApp.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp.Infrastructure.Data.Repositories
{
   public class DatabaseRepository : RepositoryBase, IDatabaseRepository
    {
        public DatabaseRepository(ISqLiteConnection sqLiteConnection) : base(sqLiteConnection)
        {
        }
    }
}
