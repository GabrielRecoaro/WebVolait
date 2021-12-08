using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebVolait.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo é obrigatório")]
        public string Usuario { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        public string Senha { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "*O campo descrição é obrigatório")]
        public bool LembraMe { get; set; }
    }
}