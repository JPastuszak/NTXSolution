

using System.Collections.Generic;
using System.Linq;
using NTXSolution.Domain.Entities;
using NTXSolution.Domain.Interfaces.Repositories;
using NTXSolution.Domain.Interfaces.Services;

namespace NTXSolution.Domain.Services
{
    public class EditoraService : ServiceBase<Editora>, IEditoraService
    {
        private readonly IEditoraRepository _EditoraRepository;

        public EditoraService(IEditoraRepository EditoraRepository)
            : base(EditoraRepository)
        {
            _EditoraRepository = EditoraRepository;
        }

        public IEnumerable<Editora> ObterEditorasEspeciais(IEnumerable<Editora> Editoras)
        {
            return Editoras.Where(c => c.EditoraEspecial(c));
        }
    }
}
