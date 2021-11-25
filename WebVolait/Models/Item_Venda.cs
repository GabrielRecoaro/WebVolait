using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Item_Venda
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_ItemVenda { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "*O campo quantidade é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo quantidade permite apenas 2 a 10 caracteres")]
        public string Qtd_ItemVenda { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "*O campo valor é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo valor permite apenas 2 a 10 caracteres")]
        public string Valor_ItemVenda { get; set; }

        [Display(Name = "Nota Fiscal")]
        [Required(ErrorMessage = "*O campo nota fiscal é obrigatório")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "*Nota fiscal inválido")]
        public string NotaFiscal { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Pacote { get; set; }


    }
}