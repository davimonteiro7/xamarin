using System.Collections.Generic;
using TesteDevXamarin.Core.Models.Domain;
using TesteDevXamarin.Core.Models.Domain.Repositories;
using Realms;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Base;
using System;

namespace TTesteDevXamarin.Core.Models.Data.Persistence.Repositories
{
    public class StateRepository : IStateRepository
    {    
        public void Save(IEnumerable<State> states)
        {
            
        }
    }
}
