using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class GroupeContact
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Nom_Groupe { get; set; }
        public DateTime Date_Creation { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
        public ICollection<Chargement_Contact> Chargement_Contacts { get; set; }

    }
}