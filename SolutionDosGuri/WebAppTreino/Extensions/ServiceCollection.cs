using WebAppTreino.Services;

namespace WebAppTreino.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddScoped(this IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        return services;
    }
 }
