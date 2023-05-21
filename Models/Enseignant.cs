using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WALASEBAI.Models
{
    public class Enseignant
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        [Display(Name = "CIN")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "CIN must be exactly 8 numbers.")]
        public string CIN { get; set; }

        public virtual ICollection<PFE>? PFEs { get; set; }

        public virtual ICollection<Soutenance>? SoutenancesEnTantQuePresident { get; set; }
        public virtual ICollection<Soutenance>? SoutenancesEnTantQueRapporteur { get; set; }

    }
}
