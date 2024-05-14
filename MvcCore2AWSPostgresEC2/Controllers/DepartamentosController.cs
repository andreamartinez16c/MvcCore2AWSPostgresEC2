﻿using Microsoft.AspNetCore.Mvc;
using MvcCore2AWSPostgresEC2.Models;
using MvcCore2AWSPostgresEC2.Repositories;

namespace MvcCore2AWSPostgresEC2.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamento repo;

        public DepartamentosController(RepositoryDepartamento repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Departamento> departamentos =
                await this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }

        public async Task<IActionResult> Details(int id)
        {
            Departamento departamento =
                await this.repo.FindDepartamentoAsync(id);
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento dept)
        {
            await this.repo.InsertDepartamentoAsync
                (dept.IdDepartamento, dept.Nombre, dept.Localidad);
            return RedirectToAction("Index");
        }
    }
}
