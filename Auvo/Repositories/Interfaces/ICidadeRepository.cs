using Auvo.Models;

namespace Auvo.Repositories.Interfaces
{
    public interface ICidadeRepository
    {
        IEnumerable<Cidade> ListCidade { get; }
        Cidade GetById(int id);

    }
}
