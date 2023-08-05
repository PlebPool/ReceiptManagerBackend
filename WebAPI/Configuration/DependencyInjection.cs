using Common;
using NetCore.AutoRegisterDi;
using Persistance;
using Persistance.Commands;
using System.Diagnostics;
using System.Reflection;

namespace WebAPI.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCommandAndQueryHandlers(this IServiceCollection services, Assembly assembly)
        {
            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(typeof(Persistance.AssemblyReference)))
                .Where(c => c.GetInterfaces().AnyHasScopeServiceAttribute())
                .AsPublicImplementedInterfaces();
            return services;
        }

        private static bool AnyHasScopeServiceAttribute(this Type[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (Attribute.IsDefined(t[i], typeof(ScopedServiceAttribute)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
