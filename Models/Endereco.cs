using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacilitaAPI.Models
{
    public class Endereco
    {
        [Required]
        public long Id { get; set; }

        public string Cep { get; set; }

        public string Rua { get; set; }

    }
}
