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
    public class CargosController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(CargoCadastroViewModel model,
            [FromServices] ICargoRepository repository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (repository.BuscarPorNome(model.Nome) != null)
                    {
                        throw new Exception($"O cargo {model.Nome} já encontra-se cadastrado");
                    }
                    else
                    {
                        var cargo = new Cargo
                        {
                            IdCargo = Guid.NewGuid(),
                            Nome = model.Nome,
                            Descricao = model.Descricao
                        };

                        repository.Inserir(cargo);
                        TempData["MensagemSucesso"] = $"O cargo {cargo.Nome} cadastrado com sucesso";
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
    }
}
