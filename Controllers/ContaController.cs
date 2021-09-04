using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projetocaixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Controllers
{

    public class ContaController : Controller
    {
        public Contexto contexto;

        public ContaController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Conta> lista = contexto.Contas.ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
           Conta novo = new Conta();
            return View(novo);
        }

    }
}
