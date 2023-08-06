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
        public static IServiceCollection RegisterScopedServicesByAttribute(this IServiceCollection services, params Type[] assemblyReferenceTypes)
        {
            for (int i = 0; i < assemblyReferenceTypes.Length; i++)
            {
                services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(assemblyReferenceTypes[i]))
                .Where(c => c.GetInterfaces().AnyTypeHasScopeServiceAttribute())
                .AsPublicImplementedInterfaces();
            }
            return services;
        }

        private static bool AnyTypeHasScopeServiceAttribute(this Type[] t)
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
