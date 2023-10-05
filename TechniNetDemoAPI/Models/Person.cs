using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechniNetDemoAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [MinLength(5)]
        public string Lastname { get; set; }

        public static List<Person> liste = new List<Person>()
        {
            new Person { Id = 1, Firstname = "Arthur", Lastname = "Pendragon" },
            new Person { Id = 2, Firstname = "Merlin", Lastname = "L'enchanteur" },
            new Person { Id = 3, Firstname = "Léodagan", Lastname = "De Carmélide" } 
        };

        public static void Ajout(Person p) { liste.Add(p); }
    }
}
