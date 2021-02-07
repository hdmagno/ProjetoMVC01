using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMvc01.Presentation.Models
{
    public class FuncionarioCadastroViewModel
    {
        public string Nome { get; set; }
        public string Salario { get; set; }

        public DateTime DataAdmissao { get; set; }

        public string IdCargo { get; set; }
        public List<SelectListItem> Cargos { get; set; }

        public string IdDepartamento { get; set; }
        public List<SelectListItem> Departamentos { get; set; }

    }
}
