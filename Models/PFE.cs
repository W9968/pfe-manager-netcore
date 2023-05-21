using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WALASEBAI.Models
{
    public class PFE
    {
        public int id { get; set; }
        
        public string Titre { get; set; }

        [Display(Name = "Description")]
        public string Desc { get; set; }

        [Display(Name ="Date Début")]
        public DateTime DateD { get; set; }

        [Display(Name = "Date Fin")]
        public DateTime DateF { get; set; }

        [ForeignKey("Enseignant")]
        public int EncadrantID { get; set; }

        [ForeignKey("Societe")]
        public int SocieteID { get; set; }

        // Navigation properties
        public virtual Enseignant? Encadrant { get; set; }
        public virtual Societe? Societe { get; set; }

        public ICollection<PFE_Etudiant>? PFEEtudiants { get; set; }

        public virtual ICollection<Soutenance>? Soutenances { get; set; }

    }
}
