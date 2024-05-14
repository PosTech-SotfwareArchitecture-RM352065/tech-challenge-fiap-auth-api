﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sanduba.Core.Application.Abstraction.Costumers;
using Sanduba.Core.Application.Costumer;

namespace Sanduba.Core.Application
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Registers the necessary services with the DI framework.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>The same service collection.</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICostumerInteractor, CostumerInteractor>();

            return services;
        }
    }
}
