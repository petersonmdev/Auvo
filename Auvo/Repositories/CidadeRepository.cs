using Auvo.Context;
using Auvo.Models;
using Auvo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Auvo.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly AppDbContext _context;
        public CidadeRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Cidade> ListCidade => _context.Cidade.Include(e => e.Estado);

        public Cidade GetById(int id)
        {
            return _context.Cidade.FirstOrDefault(c => c.CidadeId == id);
        }
    }
}
