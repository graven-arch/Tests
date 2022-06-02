using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Chargement_Contact
    {
        public int Id_Chargement { get; set; }
        public DateTime Date_Chargement { get; set; }
        public string Format_fichier { get; set; }
        public string Nom_Fichier { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
        public GroupeContact GroupeContact { get; set; }
    }
}