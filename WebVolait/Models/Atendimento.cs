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
        //[Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Atend { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string NomeCliente_Atend { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "*O campo descrição é obrigatório")]
        //[StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string Desc_Atend { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        //[Range(1, 4, ErrorMessage = "*Código inválido")]
        public int Cod_Func { get; set; }

        [Display(Name = "Data Atendimento")]
        [Required(ErrorMessage = "*A data de atendimento é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataHora_Atend
        {
            get
            {
                return this.dataHora_Atend.HasValue
                    ? this.dataHora_Atend.Value
                    : DateTime.Now;
            }
            set
            {
                this.dataHora_Atend = value;
            }


        }

        private DateTime? dataHora_Atend = null;
    }
}