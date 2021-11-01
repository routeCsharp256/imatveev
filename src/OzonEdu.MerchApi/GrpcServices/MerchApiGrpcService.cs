using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OzonEdu.MerchApi.Grpc;
using OzonEdu.MerchApi.Services.Interfaces;

namespace OzonEdu.MerchApi.GrpcServices
{
    public class MerchApiGrpcService : MerchApiGrpc.MerchApiGrpcBase
    {
        private readonly IMerchService _merchService;

        public MerchApiGrpcService(IMerchService merchService)
        {
            _merchService = merchService;
        }

        public override async Task<Empty> GiveMerch(GiveMerchRequest request, ServerCallContext context)
        {
            await _merchService.Give(request.EmployeeId, context.CancellationToken);
            return new Empty();
        }

        public override async Task<CheckMerchStatusResponse> CheckMerchStatus(GetMerchStatusRequest request, ServerCallContext context)
        {
            var status = await _merchService.Check(request.EmployeeId, context.CancellationToken);
            return new CheckMerchStatusResponse
            {
                Status = status
            };
        }
    }
}