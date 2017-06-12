
using System.Collections.Generic;
using System.Linq;
using NTXSolution.Domain.Entities;
using NTXSolution.Domain.Interfaces.Repositories;

namespace NTXSolution.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return Db.Livros.Where(p => p.Nome.Contains(nome));
        }

        public IEnumerable<Livro> BuscarPorAutor(string nome)
        {
            return Db.Livros.Where(p => p.Autor.Contains(nome));
        }
    }
}


