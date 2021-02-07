using ExcercicioMvc01.Repositoy.Contracts;
using ExcercicioMvc01.Repositoy.Entities;
using ExercicioMvc01.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioMvc01.Presentation.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Cadastro([FromServices] ICargoRepository cargoRepository,
            [FromServices] IDepartamentoRepository departamentoRepository)
        {
            return View(GetFuncionarioCadastroModel(cargoRepository, departamentoRepository));
        }

        [HttpPost]
        public IActionResult Cadastro(FuncionarioCadastroViewModel model,
            [FromServices] ICargoRepository cargoRepository,
            [FromServices] IFuncionarioRepository funcionarioRepository,
            [FromServices] IDepartamentoRepository departamentoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = new Funcionario
                    {
                        Id = Guid.NewGuid(),
                        Nome = model.Nome,
                        Salario = decimal.Parse(model.Salario),
                        DataAdmissao = DateTime.Now,
                        Id_Cargo = Guid.Parse(model.IdCargo),
                        Id_Departamento = Guid.Parse(model.IdDepartamento)
                    };

                    funcionarioRepository.Inserir(funcionario);

                    TempData["MensagemSucesso"] = @$"Funcionário {model.Nome} cadastrado com sucesso";

                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    TempData["MensagemErro"] = ex.Message;
                }
            }    
            
            return View(GetFuncionarioCadastroModel(cargoRepository, departamentoRepository));
        }

        public FuncionarioCadastroViewModel GetFuncionarioCadastroModel([FromServices] ICargoRepository cargoRepository,
            [FromServices] IDepartamentoRepository departamentoRepository)
        {
            var model = new FuncionarioCadastroViewModel();
            model.Cargos = new List<SelectListItem>();
            model.Departamentos = new List<SelectListItem>();

            foreach (var item in cargoRepository.BuscarTodos())
            {
                var items = new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Nome
                };

                model.Cargos.Add(items);
            }

            foreach (var item in departamentoRepository.BuscarTodos())
            {
                var items = new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Nome
                };

                model.Departamentos.Add(items);
            }

            return model;
        }

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Consulta(FuncionarioConsultaViewModel model,
            [FromServices] IFuncionarioRepository funcionarioRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = funcionarioRepository.BuscarPorNome(model.Nome);

                    if(result.Count() > 0)
                    {
                    model.Funcionarios = result;
                    TempData["MensagemSucesso"] = $"{result.Count()} funcionarios localizados.";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Nenhum funcionário encontrado.";
                    }

                }
                catch (Exception ex)
                {
                    TempData["MensagemErro"] = ex.Message;
                }
                
            }

            return View(model);
        }

    }
}
