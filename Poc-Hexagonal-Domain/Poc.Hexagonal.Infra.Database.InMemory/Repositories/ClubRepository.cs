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
        private static int _incrementId = 0;

        public Task<IEnumerable<Club>> GetAll()
        {
            var list = new List<Club> { new Club { Name = "Social Club" } };
            return Task.FromResult<IEnumerable<Club>>(list);
        }

        public Task<int> Insert(Club club)
        {
            _incrementId = _incrementId + 1;
            return Task.FromResult<int>(_incrementId); 
        }
    }
}
