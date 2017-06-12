using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTXSolution.MVC.ViewModels
{
    public class IdiomaViewModel
    {
        public IdiomaViewModel()
        {
            IdiomasList = new List<SelectListItem>();

        }

        public int IdiomaId { get; set; }
        public IEnumerable<SelectListItem> IdiomasList { get; set; }

    }
}