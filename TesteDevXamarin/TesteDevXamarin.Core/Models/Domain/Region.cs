using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDevXamarin.Core.Models.Domain
{
    public class Region
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public List<State> States { get; set; }

    }
}   
