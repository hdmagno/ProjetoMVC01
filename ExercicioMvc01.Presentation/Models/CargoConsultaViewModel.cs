using ExcercicioMvc01.Repositoy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMvc01.Presentation.Models
{
    public class CargoConsultaViewModel
    {
        public string Nome { get; set; }
        public List<Cargo> Cargos { get; set; }
    }
}
