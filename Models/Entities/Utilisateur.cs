using SmsGo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public DateTime Date_Creation { get; set; }
        public DateTime Date_Connexion { get; set; }
        public string Profil { get; set; }
        public Profil Profile { get; set; }
        public  Historique_Connexion Historique_Connexion{ get; set; }
        public param_Repertoire Param_Repertoire { get; set; }
        public Param_Message Param_Message { get; set; }
        public GroupeContact GroupeContact { get; set; }
        public Param_Canal Param_Canal { get; set; }
        public Type_Message Type_Message { get; set; }
        public Chargement_Contact Chargement_Contact { get; set; }



    }
}