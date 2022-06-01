using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using SmsGo.Models.Entities;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class P_MessageConfig :EntityTypeConfiguration<Param_Message>
    {
        public P_MessageConfig()
        {
            HasKey(pm => pm.Id);
            //with Messages
            HasMany(pm => pm.GroupeContacts)
                .WithMany(g => g.Param_Messages);
            //With HistoriqueEnvoi
            HasRequired(pm => pm.Historique_Envoi)
                .WithMany(h => h.Param_Messages);
            //With Utilisateur
            HasRequired(pm => pm.Utilisateur)
                .WithMany(u => u.Param_Messages);
            //With Declenchement_Message
            HasMany(pm => pm.Declenchement_Messages)
                .WithMany(d => d.Param_Messages);
        }
    }
}