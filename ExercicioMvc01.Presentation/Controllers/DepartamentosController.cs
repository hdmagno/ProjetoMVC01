using ExcercicioMvc01.Repositoy.Contracts;
using ExcercicioMvc01.Repositoy.Entities;
using ExercicioMvc01.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMvc01.Presentation.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(DepartamentoCadastroViewModel model,
            [FromServices] IDepartamentoRepository repository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(repository.BuscarPorNome(model.Nome).Count() > 0)
                    {
                        throw new Exception($"O departamento {model.Nome} já encontra-se cadastrado.");
                    }
                    else
                    {
                        var departamento = new Departamento
                        {
                            Id = Guid.NewGuid(),
                            Nome = model.Nome,
                            Descricao = model.Descricao
                        };

                        repository.Inserir(departamento);
                        TempData["MensagemSucesso"] = $"Departamento {model.Nome} cadastrado com sucesso.";
                        ModelState.Clear();
                    }
                }
                catch (Exception ex)
                {
                    TempData["MensagemErro"] = ex.Message;
                }
            }
            
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Consulta(DepartamentoConsultaViewModel model,
            [FromServices] IDepartamentoRepository departamentoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = departamentoRepository.BuscarPorNome(model.Nome);

                    if(result != null)
                    {
                        model.Departamentos = result;

                        TempData["MensagemSucesso"] = $"{model.Departamentos.Count()} departamentos obtidos na pesquisa.";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Nenhum registro encontrado";
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
