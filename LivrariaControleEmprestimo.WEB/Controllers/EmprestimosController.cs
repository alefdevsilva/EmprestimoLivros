﻿using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoServices _service = new LivroClienteEmprestimoServices();
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = _service.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimo);
        }
    }
}
