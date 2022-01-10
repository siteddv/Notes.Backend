using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Notes.Application.Interfaces;
using System.Reflection;

namespace Notes.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
