
using NTXSolution.Domain.Entities;
using System.Collections.Generic;

namespace NTXSolution.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Idioma { get; set; }
        public int Paginas { get; set; }
        public string Capa { get; set; }
        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }
    }
}
