using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDevXamarin.Core.Models.Domain
{
    public class _Region : RealmObject
    {
        public string Name { get; set; }
        public IList<State> States { get; }
        public _Region() {}

        public _Region(List<State> states)
        {
            States = states;
        }
    }
}   
