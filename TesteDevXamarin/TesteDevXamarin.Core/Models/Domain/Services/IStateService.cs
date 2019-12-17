using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace TesteDevXamarin.Core.Models.Domain.Services
{
    public interface IStateService
    {
        ObservableCollection<State> FetchStates();
        ObservableCollection<State> SearchState(string query);
        void SaveStates(Realm realmInstance, IEnumerable<State> states);
        ObservableCollection<State> GetStates(Realm realmInstance);
    }
}
    