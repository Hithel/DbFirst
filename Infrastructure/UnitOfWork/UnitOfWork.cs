

using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{

    private readonly DbFirstContext _context;




    private TeamRepository _teams;
    private DriverRepository _drivers;

    public UnitOfWork(DbFirstContext context)
    {
        _context = context;
    }

    // Controll de nulos para los repositorios




    public ITeam Teams
    {
        get
        {
            if (_teams == null)
            {
                _teams = new TeamRepository(_context);
            }
            return _teams;
        }
    }

    public IDriver Drivers
    {
        get
        {
            if (_drivers == null)
            {
                _drivers = new DriverRepository(_context);
            }
            return _drivers;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}