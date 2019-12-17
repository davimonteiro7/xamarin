using MvvmCross.ViewModels;
using System.Threading.Tasks;
using TesteDevXamarin.Core.Models.Domain;
using System.Collections.ObjectModel;
using TesteDevXamarin.Core.Models.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using System.Linq;

namespace TesteDevXamarin.Core.ViewModels
{
    public class FirstStateListViewModel : MvxViewModel
    {
        readonly IStateService _stateService;
        readonly IMvxNavigationService _navigationService;

        public FirstStateListViewModel(IStateService stateService, IMvxNavigationService navigationService)
        {
            _stateService = stateService;
            _navigationService = navigationService;

            States = _stateService.FetchStates();

            NavigateToSecondCommand = new MvxAsyncCommand(() =>
                _navigationService.Navigate<SecondStateListViewModel, ObservableCollection<State>>(States));

            NavigateToThirdCommand = new MvxAsyncCommand(() =>
                _navigationService.Navigate<ThirdStateListViewModel, ObservableCollection<State>>(States));
        }

        public IMvxAsyncCommand NavigateToSecondCommand { get; private set; }
        public IMvxAsyncCommand NavigateToThirdCommand { get; private set; }
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
