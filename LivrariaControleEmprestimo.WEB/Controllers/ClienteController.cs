﻿using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oClienteService.oRepositoryCliente.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente ocliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(ocliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente ocliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(ocliente);

        }
        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente ocliente = oClienteService.oRepositoryCliente.Alterar(model);

            int id = ocliente.Id;
            return RedirectToAction("Details", new {  id });

        }
    }
}
