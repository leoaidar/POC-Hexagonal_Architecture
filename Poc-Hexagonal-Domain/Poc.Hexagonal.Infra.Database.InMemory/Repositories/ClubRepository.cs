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
        private readonly List<Club> _list;

        public ClubRepository()
        {
            _list = new List<Club> { new Club { Name = "Social Club" } };
            _incrementId = _list.Count;
        }

        public Task<IEnumerable<Club>> GetAll()
        {            
            return Task.FromResult<IEnumerable<Club>>(_list);
        }

        public Task<int> Insert(Club club)
        {
            club.Id = _incrementId = _list.Count + 1;
            _list.Add(club);
            return Task.FromResult<int>(_incrementId); 
        }
    }
}
