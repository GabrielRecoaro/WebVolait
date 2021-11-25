using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Pacote
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Pacote { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo nome permite apenas 2 a 30 caracteres")]
        public string Nome_Pacote { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "*O campo descrição é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Desc_Pacote { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "*O campo valor é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo valor permite apenas 2 a 10 caracteres")]
        public string Valor_Pacote { get; set; }

        [Display(Name = "Destino")]
        [Required(ErrorMessage = "*O campo destino é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo destino permite apenas 2 a 10 caracteres")]
        public string Destino_Pacote { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_ItemPacote { get; set; }
    }
}