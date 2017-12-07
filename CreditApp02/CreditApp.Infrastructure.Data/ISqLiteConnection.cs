using SQLite.Net.Async;

namespace CreditApp02.Infrastructure.Data
{
    public interface ISqLiteConnection
    {
        SQLiteAsyncConnection Connection { get; }
    }
}
