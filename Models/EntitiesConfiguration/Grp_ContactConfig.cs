using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using SmsGo.Models.Entities;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class Grp_ContactConfig: EntityTypeConfiguration<GroupeContact>
    {
        public Grp_ContactConfig()
        {
            HasKey(g => g.Id_Groupe);
            //Config avec ParamMessage
            HasMany(g => g.Param_Messages)
                .WithMany(p => p.GroupeContacts);
            //config avec Utilisateur
            HasRequired(g => g.Utilisateur)
                .WithMany(u => u.GroupeContacts);
            //Config avec Chargement_Contact
            HasRequired(g => g.Chargement_Contact)
                .WithMany(c => c.GroupeContacts);
            //Config avec Contact
            HasMany(g => g.Contacts)
                .WithRequired(co => co.GroupeContact);
            //Config des attributs

        }
    }
}