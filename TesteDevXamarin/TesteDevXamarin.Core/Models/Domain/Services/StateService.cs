using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDevXamarin.Core.Models.Data.JSONMapping;
using TesteDevXamarin.Core.Models.Domain.Repositories;

namespace TesteDevXamarin.Core.Models.Domain.Services
{
    public class StateService : IStateService
    {
        public ImportStates importedStates;
        private readonly IStateRepository _stateRepository;
        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
            importedStates = new ImportStates();
        }
        public ObservableCollection<State> FetchStates()
        {
            var states = new ObservableCollection<State>();
            importedStates.GetRecords();
            
            foreach (var state in importedStates.root.records)
            {
                states.Add(new State
                {
                    Id = state.id,
                    Name = state.fields.Estado,
                    Sigla = state.fields.Sigla,
                    Capital = state.fields.Capital,
                    FlagUrl = state.fields.Attachments.FirstOrDefault().thumbnails.large.url,
                    Region = new _Region { Name = state.fields.Regiao }
                });
            }
            return states;
        }
        
        public ObservableCollection<State> SearchState(string query)
        {
            var states = FetchStates();
            var result = new ObservableCollection<State>();
            foreach (var state in states.Where(s => s.Capital.Contains(query) || s.Name.Contains(query)))
            {
                result.Add(state);
            }
            return result;
        }

        public void SaveStates(Realm realmInstance, IEnumerable<State> states)
        {
            foreach (var state in states)
            {
                realmInstance.Write(() => 
                {
                    if(!realmInstance.All<State>().Any<State>(s => s.Id == state.Id))
                    realmInstance.Add(state);
                });
            }
        }

        public ObservableCollection<State> GetStates(Realm realmInstance)
        {
            var states = new ObservableCollection<State>();
            using (var trans = realmInstance.BeginWrite())
            {
                var statesDb = realmInstance.All<State>();
                foreach (var state in statesDb)
                {
                    states.Add(state);
                }
                trans.Commit();
            };
            return states;
        }
    }
}
