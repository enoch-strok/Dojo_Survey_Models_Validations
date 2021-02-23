using System;
using System.ComponentModel.DataAnnotations;

namespace Hogwarts.Models
{
    public class HogwartsStudent
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public string Dojo { get; set; }

        public string FavoriteLanguage { get; set; }

        [MinLength(20)]
        public string Comment { get; set; }
    }
}