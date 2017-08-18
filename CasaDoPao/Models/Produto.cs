using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CasaDoPao.Models
{
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }

        [Required]
        public string NomeProduto { get; set; }


        [Required]
        public decimal Valor { get; set; }


    }
}