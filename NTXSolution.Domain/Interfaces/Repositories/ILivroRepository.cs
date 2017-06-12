using System.Collections.Generic;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Domain.Interfaces.Repositories
{
    public interface ILivroRepository : IRepositoryBase<Livro>
    {
        IEnumerable<Livro> BuscarPorNome(string nome);
        IEnumerable<Livro> BuscarPorAutor(string autor);
    }
}
