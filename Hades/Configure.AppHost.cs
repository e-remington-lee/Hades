using Funq;
using ServiceStack;
using Hades.ServiceInterface;
using Hades.ServiceInterface.Engines;

[assembly: HostingStartup(typeof(Hades.AppHost))]

namespace Hades;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("Hades", typeof(DepositHandler).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });

        var HadesConfiguration = AppSettings.Get<HadesConfiguration>("HadesConfiguration");
        Console.WriteLine(HadesConfiguration.ToJson());

        container.Register<IDepositEngine>(new DepositEngine());
    }
}
