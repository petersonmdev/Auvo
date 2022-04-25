using Auvo.Models;

namespace Auvo.Repositories.Interfaces
{
    public interface IEstadoRepository
    {
        IEnumerable<Estado> ListEstado { get; }
    }
}
