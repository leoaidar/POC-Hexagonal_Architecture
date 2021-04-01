using Poc.Hexagonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Hexagonal.Domain.Adapters
{
    public interface IClubRepository
    {
        public Task<IEnumerable<Club>> GetAll();
        public Task<int> Insert(Club club);
    }
}
