using Microsoft.AspNetCore.Mvc;
using Trabalho.Models;
using Trabalho.Repository.Interface;

namespace Trabalho.Controllers
{
    [Route("[controller]")]
    public class CaseMode : Controller
    {
        private readonly ICaseModeRepository _caseModeRepository;
        public CaseMode(ICaseModeRepository caseModeRepository)
        {
            this._caseModeRepository = caseModeRepository;
        }
        public IActionResult Index()
        {
            var result = _caseModeRepository.GetAll();
            return View(result);
        }
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var result = _caseModeRepository.GetById(id);
            return View(result);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();

        }      
        [Route("create")]
        [HttpPost]
        public IActionResult Create(CaseModeModel model)
        {
            if(!ModelState.IsValid)
            return View();
             this._caseModeRepository.Save(model);

             return RedirectToAction("Index");
        }

        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            var result = _caseModeRepository.GetById(id);
            return View(result);
        }
        [HttpPost]
        [Route("update/{id}")]
        public IActionResult Update(CaseModeModel model)
        {
            var id = model.Id;
            if(!ModelState.IsValid)
                return View(model);
            this._caseModeRepository.Update(model);
            return RedirectToAction("Index");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            if(!ModelState.IsValid)
             return RedirectToAction("Index");
             this._caseModeRepository.Delete(id);
             return RedirectToAction("Index");
        }

    }
}