using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Passeio
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Passeio { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo nome permite apenas 2 a 30 caracteres")]
        public string Nome_Passeio { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "*O campo descrição é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Desc_Passeio { get; set; }

        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "*O campo empresa é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Empresa_Passeio { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "*O campo CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "*CNPJ inválido")]
        public string CNPJ_Passeio { get; set; }

        [Display(Name = "Duração do passeio")]
        [Required(ErrorMessage = "*O campo duração do passeio é obrigatório")]
        public string Duracao_Passeio { get; set; }

        // DURACAO FALTANDO

    }
}