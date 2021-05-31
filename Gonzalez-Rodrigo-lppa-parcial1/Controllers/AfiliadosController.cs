using Gonzalez_Rodrigo_lppa_parcial1.RG.Business;
using Gonzalez_Rodrigo_lppa_parcial1.RG.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gonzalez_Rodrigo_lppa_parcial1.Controllers
{
    public class AfiliadosController : Controller
    {
        public ActionResult Index()
        {
            var biz = new AfiliadoBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliados model)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var biz = new AfiliadoBiz();
                biz.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                /// Que pasa con el error -> Bitacoras
                Console.WriteLine(e);
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new AfiliadoBiz();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Afiliados model)
        {
            var biz = new AfiliadoBiz();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var biz = new AfiliadoBiz();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Afiliados model)
        {
            var biz = new AfiliadoBiz();
            biz.Update(model);
            return RedirectToAction("Index");
        }
    }
}