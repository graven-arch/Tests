using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsGo.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<GroupeContact> GroupeContacts { get; set; }
    }
}