using SmsGo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class Declenchement_MessageConfig : EntityTypeConfiguration<Declenchement_Message>
    {
        public Declenchement_MessageConfig()
        {
            HasKey(d => d.Id_D);
            HasMany(d => d.Param_Messages)
                .WithMany(p => p.Declenchement_Messages);
        }
    }
}