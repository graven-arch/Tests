using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmsGo.Models
{
    public class BdContext : DbContext
    {
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UtilisateurConfiguration());
            modelBuilder.Configurations.Add(new ProfileConfiguration());
        }
        public BdContext(string connectionString) : base(connectionString)
        {

        }

    }
  
}