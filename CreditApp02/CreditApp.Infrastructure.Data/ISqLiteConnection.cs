using SQLite;

namespace CreditApp02.Infrastructure.Data
{
    public interface ISqLiteConnection
    {
        SQLiteAsyncConnection Connection { get; }
    }
}
