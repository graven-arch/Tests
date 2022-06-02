using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace SmsGo.Models
{
    public class UtilisateurConfiguration: EntityTypeConfiguration <Utilisateur>
    {
       public UtilisateurConfiguration()
        {
            HasKey( u=>u.Id );
            //With profil
            HasRequired(u => u.Profil)
                .WithMany(p => p.Utilisateurs)
                .HasForeignKey(u=>u.Id_Profil);
            //with Historique_Connexion
            HasMany(u => u.Historique_Connexions)
                .WithRequired(hc => hc.Utilisateur);
            //With Param_Repertoire
            HasMany(u => u.Param_Repertoires)
                .WithRequired(pr => pr.Utilisateur);
            //With Param_Canal
            HasMany(u => u.Param_Canals)
                .WithRequired(pc => pc.Utilisateur);
            //With Groupe_Contact
            HasMany(u => u.GroupeContacts)
                .WithRequired(g => g.Utilisateur);
            //With Param_Message
            HasMany(u => u.Param_Messages)
                .WithRequired(pm => pm.Utilisateur);
            //With Chargement_Contact
            HasMany(u => u.Chargement_Contacts)
                .WithRequired(c => c.Utilisateur);
            //With Type_Message
            HasMany(u => u.Type_Messages)
                .WithRequired(t => t.Utilisateur);
            
        }
    }
}