using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace VetPET.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public int IdTipoAnimal { get; set; }
        public TipoAnimal? TipoAnimal { get; set; }

        [Required]
        public DateTime DtNascimento { get; set; }  // mapeado para DATE/DATETIME

        [StringLength(50)]
        public string? Cor { get; set; }

        public float? Peso { get; set; }
        public float? Altura { get; set; }

        public ICollection<Vacina> Vacinas { get; set; } = new List<Vacina>();
    }
}
