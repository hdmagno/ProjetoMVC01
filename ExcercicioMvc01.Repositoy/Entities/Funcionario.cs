using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercicioMvc01.Repositoy.Entities
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Guid Id_Cargo { get; set; }
        public Cargo Cargo { get; set; }
        public Guid Id_Departamento { get; set; }
        public Departamento Departamento { get; set; }

    }
}
