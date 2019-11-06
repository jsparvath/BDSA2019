using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2019.Lecture09.Entities
{
    public class City
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Superhero> Superheroes { get; set; }
    }
}
