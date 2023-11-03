

using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository;
    public class TeamRepository : GenericRepo<Team>, ITeam
    {
        private readonly DbFirstContext _context;

        public TeamRepository(DbFirstContext context) : base(context)
        {
            _context = context;
        }

    }