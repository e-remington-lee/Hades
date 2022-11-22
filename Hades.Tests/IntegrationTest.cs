using Funq;
using ServiceStack;
using NUnit.Framework;
using Hades.ServiceInterface;
using Hades.ServiceModel;

namespace Hades.Tests;

public class IntegrationTest
{
    const string BaseUri = "http://localhost:2000/";
    private readonly ServiceStackHost appHost;

    class AppHost : AppSelfHostBase
    {
        public AppHost() : base(nameof(IntegrationTest), typeof(DepositHandler).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }

    public IntegrationTest()
    {
        appHost = new AppHost()
            .Init()
            .Start(BaseUri);
    }

    [OneTimeTearDown]
    public void OneTimeTearDown() => appHost.Dispose();

    public IServiceClient CreateClient() => new JsonServiceClient(BaseUri);

    [Test]
    public void Can_call_Hello_Service()
    {
        var client = CreateClient();

        var response = client.Post(new Deposit { DepositAmount = 12.0m, UserId = 1});

        Assert.AreEqual(200, (int)response.ResponseCode);
        Assert.NotNull(response.TransactionId);
    }
}