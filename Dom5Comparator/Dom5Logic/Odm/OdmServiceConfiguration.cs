using Dom5Logic.Odm.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace Dom5Logic.Odm;

public static class OdmServiceConfiguration
{
    public static void AddOdm(this IServiceCollection services)
    {
        // services.AddSingleton<IOdmSingleton, OdmSingleton>()
    }
}