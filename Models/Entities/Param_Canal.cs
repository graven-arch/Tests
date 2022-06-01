using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Param_Canal
    {
        public int Id { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}