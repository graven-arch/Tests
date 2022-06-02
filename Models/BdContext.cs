using SmsGo.Models.Entities;
using SmsGo.Models.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmsGo.Models
{
    public class BdContext : DbContext
    {
        public virtual DbSet<Chargement_Contact> Chargement_Contact { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Declenchement_Message> Declenchement_Message { get; set; }
        public virtual DbSet<DecParamMess> DecParamMess { get; set; }
        public virtual DbSet<GroupeContact> Groupe_Contact { get; set; }
        public virtual DbSet<Historique_Connexion> Historique_Connexion { get; set; }
        public virtual DbSet<Historique_Envoi> Historique_Envoi { get; set; }
        public virtual DbSet<Message_Pour> Message_Pour { get; set; }
        public virtual DbSet<Param_Canal> Param_Canal { get; set; }
        public virtual DbSet<Param_Message> Param_Message { get; set; }
        public virtual DbSet<param_Repertoire> Param_Repertoire { get; set; }
        public virtual DbSet<PlagedeNumero> PlagedeNumeros { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<Type_Message> Type_Message { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChargementContact_Config());
            modelBuilder.Configurations.Add(new ContactConfig());
            modelBuilder.Configurations.Add(new Declenchement_MessageConfig());
            modelBuilder.Configurations.Add(new DecParamMessConfig());
            modelBuilder.Configurations.Add(new Grp_ContactConfig());
            modelBuilder.Configurations.Add(new H_ConnexionConfig());
            modelBuilder.Configurations.Add(new H_EnvoiConfig());
            modelBuilder.Configurations.Add(new Message_PourConfig());
            modelBuilder.Configurations.Add(new P_CanalConfig());
            modelBuilder.Configurations.Add(new P_MessageConfig());
            modelBuilder.Configurations.Add(new P_RepertoireConfig());
            modelBuilder.Configurations.Add(new PlageConfig());
            modelBuilder.Configurations.Add(new ProfilConfiguration());
            modelBuilder.Configurations.Add(new Type_MConfig());
            modelBuilder.Configurations.Add(new UtilisateurConfiguration());
        }
        public BdContext() : base("SmsGo")
        {

        }

    }
  
}