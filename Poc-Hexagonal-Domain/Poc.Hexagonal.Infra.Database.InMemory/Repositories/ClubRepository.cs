using Poc.Hexagonal.Domain.Adapters;
using Poc.Hexagonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Hexagonal.Infra.Database.InMemory.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
