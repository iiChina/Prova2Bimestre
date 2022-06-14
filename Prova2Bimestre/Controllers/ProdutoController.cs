using Prova2Bimestre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Prova2Bimestre.Controllers
{
    public class ProdutoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProdutoModel produtoModel = db.Produtos.Find(id);

            if (produtoModel == null)
            {
                return HttpNotFound();
            }

            return View(produtoModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProdutoModel produtoModel = db.Produtos.Find(id);
            db.Produtos.Remove(produtoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}