using SQLite.Net.Async;

namespace CreditApp.Infrastructure.Data.Repositories.Base
{
    public abstract class RepositoryBase
    {
        protected readonly SQLiteAsyncConnection Database;

        protected RepositoryBase(ISqLiteConnection sqLiteConnection)
        {
            Database = sqLiteConnection.Connection;
        }
    }
}
