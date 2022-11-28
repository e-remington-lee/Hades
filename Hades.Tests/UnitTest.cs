using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using Hades.ServiceInterface;
using Hades.ServiceModel;

namespace Hades.Tests;

public class UnitTest
{
    private readonly ServiceStackHost appHost;

    public UnitTest()
    {
        appHost = new BasicAppHost().Init();
        appHost.Container.AddTransient<DepositHandler>();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown() => appHost.Dispose();

    [Test]
    public async void Can_call_MyServices()
    {
        var service = appHost.Container.Resolve<DepositHandler>();

        var response = await service.Post(new Deposit { DepositAmount = 12.0m, UserId = 1 });

        Assert.AreEqual(200, (int)response.ResponseCode);
        Assert.NotNull(response.TransactionId);

    }
}