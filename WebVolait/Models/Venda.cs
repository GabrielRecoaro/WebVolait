using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Venda
    {
        [Display(Name = "Nota Fiscal")]
        [Required(ErrorMessage = "*O campo nota fiscal é obrigatório")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "*Nota fiscal inválido")]
        public string NotaFiscal { get; set; }

        [Display(Name = "Data de venda")]
        [Required(ErrorMessage = "*O campo data de venda é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JogoDtLanc
        {
            get
            {
                return this.Data_Venda.HasValue
                    ? this.Data_Venda.Value
                    : DateTime.Now;
            }
            set
            {
                this.Data_Venda = value;
            }


        }

        private DateTime? Data_Venda = null;

        [Display(Name = "Código do funcionário")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Func { get; set; }

        [Display(Name = "Código do tipo de pagamento")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_TipoPagto { get; set; }

        [Display(Name = "Código do cliente")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Cli { get; set; }
    }
}