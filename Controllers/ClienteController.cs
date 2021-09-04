using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projetocaixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Controllers
{
    
    public class ClienteController : Controller
    {
        public Contexto contexto;

        public ClienteController (Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }
        
        [HttpGet]        
        public ActionResult Index()
        {
            List<Cliente> lista = contexto.Clientes.ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            Cliente novo = new Cliente();
            return View(novo);
        }
       
    }
}
