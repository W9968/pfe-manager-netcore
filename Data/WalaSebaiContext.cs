using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WALASEBAI.Models;

    public class WalaSebaiContext : DbContext
    {
        public WalaSebaiContext (DbContextOptions<WalaSebaiContext> options)
            : base(options)
        {
        }

        public DbSet<WALASEBAI.Models.Student> Student { get; set; } = default!;

        public DbSet<WALASEBAI.Models.Enseignant>? Enseignant { get; set; }

        public DbSet<WALASEBAI.Models.Societe>? Societe { get; set; }

        public DbSet<WALASEBAI.Models.PFE>? PFE { get; set; }

        public DbSet<WALASEBAI.Models.PFE_Etudiant>? PFE_Etudiant { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enseignant>()
            .HasMany(e => e.SoutenancesEnTantQuePresident)
            .WithOne(s => s.President)
            .HasForeignKey(s => s.PresidentID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Enseignant>()
            .HasMany(e => e.SoutenancesEnTantQueRapporteur)
            .WithOne(s => s.Rapporteur)
            .HasForeignKey(s => s.RapporteurID)
            .OnDelete(DeleteBehavior.NoAction);
    }

    public DbSet<WALASEBAI.Models.Soutenance>? Soutenance { get; set; }

}
