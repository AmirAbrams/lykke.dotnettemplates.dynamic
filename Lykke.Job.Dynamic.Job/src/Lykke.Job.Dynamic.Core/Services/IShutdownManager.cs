using System.Threading.Tasks;

namespace Lykke.Job.Dynamic.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}
