using Auvo.Context;
using Auvo.Models;
using Auvo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Auvo.Repositories
{
    public class PrevisaoClimaRepository : IPrevisaoClimaRepository
    {
        private readonly AppDbContext _context;
        public PrevisaoClimaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<PrevisaoClima> ListPrevisaoClima => _context.PrevisaoClima.Include(c => c.Cidade);

        public IEnumerable<PrevisaoClima> ListPrevisaoClimaTopQuente => _context.PrevisaoClima
            .OrderByDescending(p => p.TemperaturaMaxima)
            .Take(3)
            .Include(c => c.Cidade);

        public IEnumerable<PrevisaoClima> ListPrevisaoClimaTopFrio => _context.PrevisaoClima
            .OrderBy(p => p.TemperaturaMinima)
            .Take(3)
            .Include(c => c.Cidade);

        public IEnumerable<PrevisaoClima> ListPrevisaoClimaByCidadeId(int id) => _context.PrevisaoClima
            .Where(p => p.CidadeId == id)
            .Include(c => c.Cidade);
    }
}
