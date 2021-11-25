using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Tipo_Hosp
    {
        [Display(Name = "Código do tipo de hospedagem")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_TipoHosp { get; set; }

        /*[Display(Name = "Tipo de hospedagem")]
        [Required(ErrorMessage = "*O campo tipo de hospedagem é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Tipo_Hosp { get; set; }*/ 

        //ERRO COM NOME
    }
}