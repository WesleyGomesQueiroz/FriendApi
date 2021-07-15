using Friend.Domain.Interfaces.Repository;
using Friend.Domain.Interfaces.Services;
using Friend.Domain.Services;
using Friend.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Friend.Infra.IoC
{
    public class SimpleInjectorContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
