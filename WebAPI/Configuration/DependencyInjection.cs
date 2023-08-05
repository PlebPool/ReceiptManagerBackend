using NetCore.AutoRegisterDi;
using Persistance.Commands;
using System.Diagnostics;
using System.Reflection;

namespace WebAPI.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCommandAndQueryHandlers(this IServiceCollection services, Assembly assembly)
        {
            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(typeof(ICommandHandlerMarker)))
                .Where(c => c.Name.EndsWith("QueryHandler") || c.Name.EndsWith("CommandHandler"))
                .AsPublicImplementedInterfaces();
            return services;
        }
    }
}
