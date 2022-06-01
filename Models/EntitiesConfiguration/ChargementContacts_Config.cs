using SmsGo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class ChargementContacts_Config:EntityTypeConfiguration<Chargement_Contact>
    {
        public ChargementContacts_Config()
        {
            HasKey(c => c.Id_Chargement);
            HasMany(c => c.Utilisateurs)
                .WithRequired(u => u.Chargement_Contact);
        }
    }
}