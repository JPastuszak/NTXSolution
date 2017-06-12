
using System.Collections.Generic;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Application.Interface
{
    public interface ILivroAppService : IAppServiceBase<Livro>
    {
        IEnumerable<Livro> BuscarPorNome(string nome);
        IEnumerable<Livro> BuscarPorAutor(string autor);
    }
}
