using Microsoft.Extensions.DependencyInjection;
using Poc.Hexagonal.Domain.Adapters;
using Poc.Hexagonal.Infra.Database.InMemory.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Hexagonal.Infra.Database.InMemory
{
    public static class DatabaseInMemoryModuleDependency
    {
        public static void AddDatabaseInMemoryModule(this IServiceCollection services)
        {
            services.AddTransient<IClubRepository, ClubRepository>();
        }
    }
}
