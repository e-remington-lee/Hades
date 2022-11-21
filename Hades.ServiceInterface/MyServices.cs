using ServiceStack;
using Hades.ServiceModel;

namespace Hades.ServiceInterface;

public class MyServices : Service
{
    public HelloResponse Get(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }

    public DepositResponse Get(Deposit deposit)
    {
        return new DepositResponse() { ResponseCode = 200 };
    }


}