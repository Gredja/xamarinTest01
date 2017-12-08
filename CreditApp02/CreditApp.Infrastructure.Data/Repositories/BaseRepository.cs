using SQLite;

namespace CreditApp02.Infrastructure.Data.Repositories
{
   public abstract class BaseRepository
    {
        protected readonly SQLiteAsyncConnection Database;

        protected BaseRepository(ISqLiteConnection sqLiteConnection)
        {
            Database = sqLiteConnection.Connection;
        }
    }
}
