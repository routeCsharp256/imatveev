using System.Threading;
using System.Threading.Tasks;

namespace OzonEdu.MerchApi.HttpsClients.Interfaces
{
    public interface IMerchHttpClient
    {
        Task V1GiveMerch(long employeeId, CancellationToken token);

        Task<bool> V1CheckMerch(long employeeId, CancellationToken token);
    }
}