using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Type_Message
    {
        public int Id { get; set; }
        public String Libelle_Type  { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}