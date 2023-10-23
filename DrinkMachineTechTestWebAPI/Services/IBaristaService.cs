using DrinkMachineTechTestWebAPI.Requests;
using DrinkMachineTechTestWebAPI.Responses;

namespace DrinkMachineTechTestWebAPI.Services
{
    public interface IBaristaService
    {
        Task<PerformStepResponse> Post(PerformStepRequest request, CancellationToken cancellationToken);
    }
}
