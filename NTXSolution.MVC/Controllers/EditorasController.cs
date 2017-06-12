using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using NTXSolution.Application.Interface;
using NTXSolution.Domain.Entities;
using NTXSolution.MVC.ViewModels;

namespace NTXSolution.MVC.Controllers
{
    public class EditorasController : Controller
    {
        private readonly IEditoraAppService _EditoraApp;

        public EditorasController(IEditoraAppService EditoraApp)
        {
            _EditoraApp = EditoraApp;
        }

        // GET: Editoras
        public ActionResult Index()
        {
            var EditoraViewModel = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModel>>(_EditoraApp.GetAll());
            return View(EditoraViewModel);
        }

        public ActionResult Especiais()
        {
            var EditoraViewModel = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModel>>(_EditoraApp.ObterEditorasEspeciais());

            return View(EditoraViewModel);
        }

        // GET: Editoras/Details/5
        public ActionResult Details(int id)
        {
            var Editora = _EditoraApp.GetById(id);
            var EditoraViewModel = Mapper.Map<Editora, EditoraViewModel>(Editora);

            return View(EditoraViewModel);
        }

        // GET: Editoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editoras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditoraViewModel Editora)
        {
            if (ModelState.IsValid)
            {
                var EditoraDomain = Mapper.Map<EditoraViewModel, Editora>(Editora);
                _EditoraApp.Add(EditoraDomain);

                return RedirectToAction("Index");
            }

            return View(Editora);
        }

        // GET: Editoras/Edit/5
        public ActionResult Edit(int id)
        {
            var Editora = _EditoraApp.GetById(id);
            var EditoraViewModel = Mapper.Map<Editora, EditoraViewModel>(Editora);

            return View(EditoraViewModel);
        }

        // POST: Editoras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditoraViewModel Editora)
        {
            if (ModelState.IsValid)
            {
                var EditoraDomain = Mapper.Map<EditoraViewModel, Editora>(Editora);
                _EditoraApp.Update(EditoraDomain);

                return RedirectToAction("Index");
            }

            return View(Editora);
        }

        // GET: Editoras/Delete/5
        public ActionResult Delete(int id)
        {
            var Editora = _EditoraApp.GetById(id);
            var EditoraViewModel = Mapper.Map<Editora, EditoraViewModel>(Editora);

            return View(EditoraViewModel);
        }

        // POST: Editoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Editora = _EditoraApp.GetById(id);
            _EditoraApp.Remove(Editora);

            return RedirectToAction("Index");
        }
    }
}
