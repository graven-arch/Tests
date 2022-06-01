using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Param_Message
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime Date_Envoi { get; set; }
        public ICollection<Historique_Envoi> Historique_Envois { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}