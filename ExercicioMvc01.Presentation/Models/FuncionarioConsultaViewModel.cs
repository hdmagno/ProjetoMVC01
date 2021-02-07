using ExcercicioMvc01.Repositoy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMvc01.Presentation.Models
{
    public class FuncionarioConsultaViewModel
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public Departamento Departamento { get; set; }
        public Cargo Cargo { get; set; }
    }
}
