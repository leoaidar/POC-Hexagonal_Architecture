using Microsoft.Extensions.DependencyInjection;
using Poc.Hexagonal.Application.Services;
using Poc.Hexagonal.Domain.Adapters;
using Poc.Hexagonal.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Hexagonal.Services
{
    public static class ApplicationModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<IClubService, ClubServiceManager>();
        }
    }
}
