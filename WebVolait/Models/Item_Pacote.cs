using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVolait.Models
{
    public class Item_Pacote
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_ItemPacote { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int Cod_Pacote { get; set; }




    }
}