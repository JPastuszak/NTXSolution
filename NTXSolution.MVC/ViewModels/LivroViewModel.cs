
using NTXSolution.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NTXSolution.MVC.ViewModels
{
    public class LivroViewModel
    {
              
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }


        public string Autor { get; set; }
        public string Idioma { get; set; }
        public int Paginas { get; set; }
        public string Capa { get; set; }

        /*
        [DataType(DataType.Currency)]
         [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }*

        [DisplayName("Disponivel?")]

        public bool Disponivel { get; set; }*/

        public int EditoraId { get; set; }
        public virtual EditoraViewModel Editora { get; set; }
    }

    internal class ctor
    {
    }
}