using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using SmsGo.Models.Entities;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class Pr_ParamConfig:EntityTypeConfiguration<Profil_Parametrage>
    {
        public Pr_ParamConfig()
        {
            HasKey(prp => prp.Id_Param);
        }
    }
}