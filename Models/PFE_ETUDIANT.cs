using System.ComponentModel.DataAnnotations.Schema;

namespace WALASEBAI.Models
{
    public class PFE_Etudiant
    {
        public int ID { get; set; }

        [ForeignKey("PFE")]
        public int PFEID { get; set; }

        [ForeignKey("Etudiant")]
        public int EtudiantID { get; set; }

        // Navigation properties
        public virtual PFE? PFE { get; set; }
        public virtual Student? Etudiant { get; set; }
    }
}
