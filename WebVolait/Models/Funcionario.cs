using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Func { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string NomeCompleto_Func { get; set; }

        [Display(Name = "Nome Social")]
        
        [StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string NomeSocial_Func { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "*O campo CPF é obrigatório")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "*CPF inválido")]
        public string CPF_Func { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "*E-mail em formato inválido.")]
        [Required(ErrorMessage = "*O campo E-mail é obrigatório")]
        public string Email_Func { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "*O campo senha é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string Senha_Func { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "*O campo telefone é obrigatório")]
        [StringLength(17, MinimumLength = 10, ErrorMessage = "*Número de contato inválido")]
        public string Telefone_Func { get; set; }
    }
}