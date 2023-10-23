using DrinkMachineTechTestWebAPI.Requests;
using DrinkMachineTechTestWebAPI.Responses;

namespace DrinkMachineTechTestWebAPI.Services
{
    public class BaristaService : IBaristaService
    {

        public async Task<PerformStepResponse> Post(PerformStepRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(1500, cancellationToken);
                return new PerformStepResponse { Success = true };
            }
            catch (TaskCanceledException e)
            {
                throw;
            }
            catch (Exception e)
            {
                return new PerformStepResponse { Success = false, ErrorMessage = e.Message };
            }
        }
    }
}
