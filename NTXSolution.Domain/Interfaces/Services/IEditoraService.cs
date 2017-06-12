
using System.Collections.Generic;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Domain.Interfaces.Services
{
    public interface IEditoraService : IServiceBase<Editora>
    {
        IEnumerable<Editora> ObterEditorasEspeciais(IEnumerable<Editora> Editoras);
    }
}
