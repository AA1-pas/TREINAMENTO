using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CorreiosWebApi.Models
{
    public class Endereco
    {
        [Key]
        public int Key { get; set; }
        [StringLength(50)]
        public string Logradouro { get; set; } = string.Empty;
        [StringLength(50)]
        public string Bairro { get; set; } = string.Empty;
        public int CEP { get; set; } = 0;
        [MaxLength(2)]
        public string UF { get; set; } = string.Empty;
        [MaxLength(30)]
        public string Municipio { get; set; } = string.Empty;
        [StringLength(30)]
        public string Complemento { get; set; } = string.Empty;
    }
}