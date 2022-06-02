using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Historique_Connexion
    {
         public int Id_Historique { get; set; }
        public string ip { get; set; }
        public DateTime DateheureCon { get; set; }
        public string Action { get; set; }
        public int Id_Utilisateur { get; set; }
        public  Utilisateur Utilisateur { get; set; }
    }
}