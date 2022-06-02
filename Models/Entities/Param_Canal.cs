using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Param_Canal
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<PlagedeNumero> PlagedeNumeros { get; set; }
        public int Id_Utilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}