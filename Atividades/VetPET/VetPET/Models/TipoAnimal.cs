using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace VetPET.Models
{
    public class TipoAnimal
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Animal> Animais { get; set; } = new List<Animal>();
    }
}
