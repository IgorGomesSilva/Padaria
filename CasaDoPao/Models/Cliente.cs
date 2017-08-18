using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CasaDoPao.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        public long CPF { get; set; }

    }
}