using System.Threading.Tasks;

namespace Study02.Infrastructure.Data.Repositories.Interfaces
{
    public interface IDatabaseRepository
    {
        Task CreateDatabaseAsync();
    }
}
