using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Historique_Connexion
    {
         public int Id_Historique { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}