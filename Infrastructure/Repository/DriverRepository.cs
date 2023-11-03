

using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository;
    public class DriverRepository : GenericRepo<Driver>, IDriver
    {
        private readonly DbFirstContext _context;

        public DriverRepository(DbFirstContext context) : base(context)
        {
            _context = context;
        }

    }