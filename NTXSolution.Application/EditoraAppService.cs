

using System.Collections.Generic;
using NTXSolution.Application.Interface;
using NTXSolution.Domain.Entities;
using NTXSolution.Domain.Interfaces.Services;

namespace NTXSolution.Application
{
    public class EditoraAppService : AppServiceBase<Editora>, IEditoraAppService
    {
        private readonly IEditoraService _EditoraService;

        public EditoraAppService(IEditoraService EditoraService)
            : base(EditoraService)
        {
            _EditoraService = EditoraService;
        }

        public IEnumerable<Editora> ObterEditorasEspeciais()
        {
            return _EditoraService.ObterEditorasEspeciais(_EditoraService.GetAll());
        }
    }
}
