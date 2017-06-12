
using System.Collections.Generic;
using NTXSolution.Application.Interface;
using NTXSolution.Domain.Entities;
using NTXSolution.Domain.Interfaces.Services;

namespace NTXSolution.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _LivroService;

        public LivroAppService(ILivroService LivroService)
            : base(LivroService)
        {
            _LivroService = LivroService;
        }

        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return _LivroService.BuscarPorNome(nome);
        }

        public IEnumerable<Livro> BuscarPorAutor(string autor)
        {
            return _LivroService.BuscarPorAutor(autor);
        }
    }
}
