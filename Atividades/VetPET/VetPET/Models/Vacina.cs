using System;
using System.ComponentModel.DataAnnotations;

namespace VetPET.Models
{
    public class Vacina
    {
        public class Vacina
        {
            public int Id { get; set; }

            [Required, StringLength(255)]
            public string Nome { get; set; } = string.Empty;

            [Required]
            public DateTime DataAplicacao { get; set; }

            [Required]
            public int IdAnimal { get; set; }
            public Animal? Animal { get; set; }

        }
    }
}
