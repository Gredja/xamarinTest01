using SQLite.Net.Async;

namespace Study02.Infrastructure.Data.Repositories
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
