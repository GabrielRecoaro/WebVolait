using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Transporte
    {

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Transp { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "*O campo CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "*CNPJ inválido")]
        public string CNPJ_Transp { get; set; }

        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "*O campo empresa é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo empresa permite apenas 2 a 30 caracteres")]
        public string Empresa_Transp { get; set; }

        [Display(Name = "Código tipo de transporte")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_TipoTransp { get; set; }

        [Display(Name = "Duração do transporte")]
        [Required(ErrorMessage = "*O campo duração do transporte é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Duração do transporte inválido")]
        public int Duracao_Transp { get; set; }
    }
}