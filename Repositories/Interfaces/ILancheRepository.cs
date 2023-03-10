using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; } // Acesso total
        IEnumerable<Lanche> LanchePreferido { get; } // Acesso total
        Lanche GetLancheById(int lancheId); // Acesso por consulta condicioanl

    }
}
