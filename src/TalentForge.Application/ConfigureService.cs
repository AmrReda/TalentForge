using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TalentForge.Application.Common.Behaviours;

namespace TalentForge.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AuthorizationBehaviour<,>).Assembly));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));

        return services;
    }
}