using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using NTXSolution.Application.Interface;
using NTXSolution.Domain.Entities;
using NTXSolution.MVC.ViewModels;
using System.Linq;
using System;

namespace NTXSolution.MVC.Controllers
{
    public class LivrosController : Controller
    {
        // GET: Livros
        private readonly ILivroAppService _LivroApp;
        private readonly IEditoraAppService _EditoraApp;
        private readonly IdiomaViewModel _idiomaview;
        public LivrosController(ILivroAppService LivroApp, IEditoraAppService EditoraApp)
        {
            _LivroApp = LivroApp;
            _EditoraApp = EditoraApp;
        }

        // GET: Editora
        public ActionResult Index()
        {
            var LivroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_LivroApp.GetAll());

            return View(LivroViewModel);
        }

        

        // GET: Editora/Details/5
        public ActionResult Details(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // GET: Editora/Create
        public ActionResult Create()
        {
            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome");
            //Iniciando a criação dos Comboc para Validar
            Idioma[] values = (Idioma[])Enum.GetValues(typeof(Idioma));
            var valuesWithNames = from value in values
                                  select new { name = value.ToString(), value = (int)value };
            ViewBag.IdiomaId = valuesWithNames;
            return View();
        }

        // POST: Editora/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _LivroApp.Add(LivroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome", Livro.EditoraId);
            return View(Livro);
        }

        // GET: Editora/Edit/5
        public ActionResult Edit(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome", LivroViewModel.EditoraId);

            return View(LivroViewModel);
        }

        public ActionResult ConsultaPorNome(string Nome)
        {
            var LivroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_LivroApp.BuscarPorNome(Nome));

            return View(LivroViewModel);
        }

        public ActionResult ConsultaPorAutor(string Autor)
        {
            var LivroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_LivroApp.BuscarPorAutor(Autor));

            return View(LivroViewModel);
        }

        // POST: Editora/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _LivroApp.Update(LivroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome", Livro.EditoraId);
            return View(Livro);
        }

        // GET: Editora/Delete/5
        public ActionResult Delete(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // POST: Editora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Livro = _LivroApp.GetById(id);
            _LivroApp.Remove(Livro);

            return RedirectToAction("Index");
        }
    }
}