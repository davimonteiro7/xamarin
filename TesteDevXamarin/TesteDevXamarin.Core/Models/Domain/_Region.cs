using Realms;
using System.Collections.Generic;

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
