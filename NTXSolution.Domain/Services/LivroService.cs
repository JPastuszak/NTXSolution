
using System.Collections.Generic;
using NTXSolution.Domain.Entities;
using NTXSolution.Domain.Interfaces.Repositories;
using NTXSolution.Domain.Interfaces.Services;

namespace NTXSolution.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _LivroRepository;

        public LivroService(ILivroRepository LivroRepository)
            : base(LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }

        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return _LivroRepository.BuscarPorNome(nome);
        }

        public IEnumerable<Livro> BuscarPorAutor(string nome)
        {
            return _LivroRepository.BuscarPorAutor(nome);
        }
    }
}
