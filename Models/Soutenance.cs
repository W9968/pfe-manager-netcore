using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WALASEBAI.Models
{
    public class Soutenance
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Heure { get; set; }

        [ForeignKey("PFE")]
        public int PFEID { get; set; }

        [ForeignKey("President")]
        public int PresidentID { get; set; }

        [ForeignKey("Rapporteur")]
        public int RapporteurID { get; set; }

        // Navigation properties
        public virtual PFE? PFE { get; set; }
        public virtual Enseignant? President { get; set; }
        public virtual Enseignant? Rapporteur { get; set; }

    }
}
