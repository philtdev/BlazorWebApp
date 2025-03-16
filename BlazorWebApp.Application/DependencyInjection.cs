using BlazorWebApp.Application.Articles;

using Microsoft.Extensions.DependencyInjection;

namespace BlazorWebApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IArticleService, ArticleService>();

        return services;
    }
}
