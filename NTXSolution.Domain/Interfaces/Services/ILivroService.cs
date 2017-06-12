using System.Collections.Generic;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> BuscarPorNome(string nome);
        IEnumerable<Livro> BuscarPorAutor(string autor);
    }
}
