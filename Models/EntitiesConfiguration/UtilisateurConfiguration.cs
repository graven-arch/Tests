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
            HasRequired(u => u.Profile)
                .WithMany(p => p.Utilisateurs);
            
        }
    }
}