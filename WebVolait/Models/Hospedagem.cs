using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Hospedagem
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Hosp { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo nome permite apenas 2 a 30 caracteres")]
        public string Nome_Hosp { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "*O campo CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "*CNPJ inválido")]
        public string CNPJ_Hosp { get; set; }

        [Display(Name = "Código do tipo de hospedagem")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_TipoHosp { get; set; }

        //NUM DIARIAS FALTANDO
    }
}