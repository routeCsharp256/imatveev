using System;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchApi.Services.Interfaces;

namespace OzonEdu.MerchApi.Services
{
    public class MerchService : IMerchService
    {
        public Task Give(long employeeId, CancellationToken _)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Check(long employeeId, CancellationToken _)
        {
            return Task.FromResult(true);
            throw new NotImplementedException();
        }
    }
}