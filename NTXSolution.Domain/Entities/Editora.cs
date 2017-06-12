using System;
using System.Collections.Generic;

namespace NTXSolution.Domain.Entities
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }

        public bool EditoraEspecial(Editora editora)
        {
            return true; // Editora.Ativo && DateTime.Now.Year - Editora.DataCadastro.Year >= 5;
        }
    }
}
