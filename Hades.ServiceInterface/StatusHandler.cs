using Hades.ServiceModel.Status;
using ServiceStack;


namespace Hades.ServiceInterface
{
    public class StatusHandler : Service
    {
        public StatusResponse Get(StatusRequest request)
        {
            var response = new StatusResponse() { StatusMessage = "Healthy" };
            return response;
        }
    }
}
