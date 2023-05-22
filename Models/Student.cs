using System.ComponentModel.DataAnnotations;

namespace WALASEBAI.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        [Display(Name ="Date Naissance")]
        [DataType(DataType.Date)]
        public DateTime DateNaiss { get; set; }

        public ICollection<PFE_Etudiant>? PFEEtudiants { get; set; }
    }
}