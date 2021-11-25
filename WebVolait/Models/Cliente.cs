using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Cliente
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Cli { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas 2 a 30 caracteres")]
        public string Nome_Cli { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "*O campo CPF é obrigatório")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "*CPF inválido")]
        public string CPF_Cli { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "*E-mail em formato inválido.")]
        [Required(ErrorMessage = "*O campo E-mail é obrigatório")]
        public string Email_Cli { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "*O campo telefone é obrigatório")]
        [StringLength(20, MinimumLength = 9, ErrorMessage = "*Número de contato inválido")]
        public string Telefone_Cli { get; set; }


    }
}