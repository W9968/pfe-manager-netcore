using System.ComponentModel.DataAnnotations;

namespace WALASEBAI.Models
{
    public class Societe
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        [Display(Name = "Libellé")]
        [MinLength(4, ErrorMessage = "Lib must be at least 4 characters long.")]
        public string Lib { get; set; }

        [MinLength(10, ErrorMessage = "Adresse must be at least 10 characters long.")]
        public string Adresse { get; set; }

        [Display(Name ="Téléphone")]
        [RegularExpression("^[5|2|9|4|3][0-9]{7}$", ErrorMessage = "Tel must start with 5, 2, 9, 4, or 3 and have a total of 8 numbers.")]
        public string Tel { get; set; }

        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Invalid email address.")]
        public string Mail { get; set; }

        // Navigation properties
        public virtual ICollection<PFE>? Pfes { get; set; }
    }
}
