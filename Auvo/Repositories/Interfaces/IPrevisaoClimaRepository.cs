using Auvo.Models;

namespace Auvo.Repositories.Interfaces
{
    public interface IPrevisaoClimaRepository
    {
        IEnumerable<PrevisaoClima> ListPrevisaoClima { get; }

        IEnumerable<PrevisaoClima> ListPrevisaoClimaTopQuente { get; }

        IEnumerable<PrevisaoClima> ListPrevisaoClimaTopFrio { get; }

        IEnumerable<PrevisaoClima> ListPrevisaoClimaByCidadeId(int id);
    }
}
