using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Hexagonal.Domain.Adapters
{
    public interface IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body);
    }
}
