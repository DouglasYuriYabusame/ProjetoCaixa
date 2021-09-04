using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projetocaixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Controllers
{

    public class LancamentoController : Controller
    {
        public Contexto contexto;

        public LancamentoController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Lancamento> lista = contexto.Lancamentos.ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            Lancamento novo = new Lancamento();
            return View(novo);
        }

    }
}
