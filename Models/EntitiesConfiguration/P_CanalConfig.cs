using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using SmsGo.Models.Entities;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class P_CanalConfig: EntityTypeConfiguration<Param_Canal>
    {
        public P_CanalConfig() 
        {
            HasKey(p => p.Id);
            HasRequired(p => p.Utilisateur)
                .WithMany(u => u.Param_Canals)
                .HasForeignKey(p=>p.Id_Utilisateur);
        }
    }
}