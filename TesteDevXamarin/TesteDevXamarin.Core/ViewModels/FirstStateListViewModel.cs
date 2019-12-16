using MvvmCross.ViewModels;
using System.Threading.Tasks;
using TesteDevXamarin.Core.Models.Domain;
using System.Collections.ObjectModel;
using TesteDevXamarin.Core.Models.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace TesteDevXamarin.Core.ViewModels
{
    public class FirstStateListViewModel : MvxViewModel
    {
        readonly IStateService _stateService;

        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            SearchResults = _stateService.SearchState(query);
        });

        private ObservableCollection<State> searchResults;
        public ObservableCollection<State> SearchResults
        {
            get 
            {
                return searchResults;
            }
            set 
            {
                searchResults = value;
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<State> _states;
        public ObservableCollection<State> States 
        {
            get 
            {
                return _states;
            }
            set 
            { 
                _states = value;
                RaisePropertyChanged();
            }
        }

        public FirstStateListViewModel(IStateService stateService)
        {
            _stateService = stateService;
            States = _stateService.FetchStates();

        }
        public override void ViewAppeared()
        {
            base.ViewAppeared();      
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
