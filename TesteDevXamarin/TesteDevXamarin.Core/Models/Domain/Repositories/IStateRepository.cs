using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteDevXamarin.Core.Models.Domain.Repositories
{
    public interface IStateRepository
    {
        void Save(IEnumerable<State> states);
    }
}
