using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SmsGo.Models
{
    public class ProfileConfiguration: EntityTypeConfiguration<Profil>
    {
        public ProfileConfiguration()
        {
            HasKey(p => p.Id_Profil);
            HasMany(p => p.Utilisateurs)
                .WithRequired(u => u.Profile);
        }
    }
}