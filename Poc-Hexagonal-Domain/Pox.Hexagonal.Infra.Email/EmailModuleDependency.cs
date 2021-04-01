using Microsoft.Extensions.DependencyInjection;
using Poc.Hexagonal.Domain.Adapters;
using Poc.Hexagonal.Infra.Email.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Hexagonal.Infra.Email
{
    public static class EmailModuleDependency
    {
        public static void AddEmailModule(this IServiceCollection services)
        {
            services.AddTransient<IEmailAdapter, EmailManager>();
        }
    }
}
