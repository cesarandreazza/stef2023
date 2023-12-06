using WebAppTreino.Repositories;
using WebAppTreino.Services;

namespace WebAppTreino.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddScoped(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
