using System.Threading.Tasks;

namespace CreditApp02.Infrastructure.Data
{
    public interface IDatabaseManager
    {
        Task ConfigureAsync();
    }
}
