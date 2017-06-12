
using System.Collections.Generic;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Application.Interface
{
    public interface IEditoraAppService : IAppServiceBase<Editora>
    {
        IEnumerable<Editora> ObterEditorasEspeciais();
    }
}
