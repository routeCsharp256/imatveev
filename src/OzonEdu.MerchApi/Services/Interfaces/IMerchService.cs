using System.Threading;
using System.Threading.Tasks;

namespace OzonEdu.MerchApi.Services.Interfaces
{
    public interface IMerchService
    {
        Task Give(long employeeId, CancellationToken token);

        Task<bool> Check(long employeeId, CancellationToken token);
    }
}