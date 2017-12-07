using System.Threading.Tasks;

namespace CreditApp02.Infrastructure.Data.Repositories.Interfaces
{
    public interface IDatabaseRepository
    {
        Task CreateDatabaseAsync();
    }
}
