using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListaNomes.Models
{
    public class Pessoa
    {
        [Key]
        public int Key { get; set; }
        public int Idade { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;
    }
}