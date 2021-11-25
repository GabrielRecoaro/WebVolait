using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Atendimento
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Atend { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string NomeCliente_Atend { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "*O campo descrição é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Desc_Atent { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Func { get; set; }

        // DATA HORA FALTANDO 
    }
}