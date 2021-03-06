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
        public  ICollection<Historique_Connexion> Historique_Connexions{ get; set; }
        public param_Repertoire Param_Repertoire { get; set; }
        public ICollection<Param_Message> Param_Messages { get; set; }
        public ICollection<GroupeContact> GroupeContacts { get; set; }
        public ICollection<Param_Canal> Param_Canals { get; set; }
        public ICollection<Type_Message> Type_Messages { get; set; }
        public Chargement_Contact Chargement_Contact { get; set; }



    }
}