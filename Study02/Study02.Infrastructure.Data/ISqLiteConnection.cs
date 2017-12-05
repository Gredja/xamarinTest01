using SQLite.Net.Async;

namespace Study02.Infrastructure.Data
{
    public interface ISqLiteConnection
    {
        SQLiteAsyncConnection Connection { get; }
    }
}
