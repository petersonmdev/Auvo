using Auvo.Context;
using Auvo.Models;
using Auvo.Repositories.Interfaces;

namespace Auvo.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly AppDbContext _context;

        public EstadoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estado> ListEstado => _context.Estado;
    }
}
