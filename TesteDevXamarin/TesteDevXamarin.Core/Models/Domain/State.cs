using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDevXamarin.Core.Models.Domain
{
    public class State : RealmObject
    {
        public State() {}
        [PrimaryKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sigla { get; set; }
        public string Capital { get; set; }
        public string FlagUrl { get; set; }
        public _Region Region { get; set; }
    }
}
