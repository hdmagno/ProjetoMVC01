using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMvc01.Presentation.Models
{
    public class DepartamentoCadastroViewModel
    {
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do {0}.")]
        public string Nome { get; set; }
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do {0}.")]
        public string Descricao { get; set; }
    }
}
