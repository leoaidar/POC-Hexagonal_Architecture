using Poc.Hexagonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Hexagonal.Domain.Services
{
    public interface IClubService
    {
        public Task<IEnumerable<Club>> RecoverAllClubs();
        public Task<int> RegisterAClub(Club club);
    }
}
