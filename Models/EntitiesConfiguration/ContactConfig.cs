using SmsGo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SmsGo.Models.EntitiesConfiguration
{
    public class ContactConfig:EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            HasKey(c => c.Id);
            HasRequired(c => c.GroupeContact)
             .WithMany(g => g.Contacts)
             .HasForeignKey(c=>c.Id_Groupe);
        }
    }
}