using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercicioMvc01.Repositoy.Entities
{
    public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Guid IdCargo { get; set; }
        public Cargo Cargo { get; set; }
        public Guid IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }

    }
}
