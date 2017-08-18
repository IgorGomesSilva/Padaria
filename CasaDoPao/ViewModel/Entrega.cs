using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CasaDoPao.ViewModel
{
    public class Entrega 
    {
        [Key]
        public int idEntrega { get; set; }

        [Required]
        public string Cliente { get; set; }

        [Required]
        public string Produto01 { get; set; }

        [Required]
        public string Produto02 { get; set; }

        [Required]
        public string Produto03 { get; set; }


        [Required]
        public decimal ValorTotal { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public int NumeroCasa { get; set; }



        
    }
}