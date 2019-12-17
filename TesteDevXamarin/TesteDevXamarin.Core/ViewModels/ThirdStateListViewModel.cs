using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TesteDevXamarin.Core.Models.Domain;
using TesteDevXamarin.Core.Models.Domain.Services;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using Realms;

namespace TesteDevXamarin.Core.ViewModels
{
    public class ThirdStateListViewModel : MvxViewModel<ObservableCollection<State>>
    {
        readonly IStateService _stateService;
        readonly Realm realmInstance = Realm.GetInstance();
        private ObservableCollection<State> _localStates;
        public ObservableCollection<State> LocalStates {
            get {
                return _localStates;
            }
            set {
                _localStates = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<State> States;
           
        public ThirdStateListViewModel(IStateService stateService)
        {
            _stateService = stateService;
            LocalStates = _stateService.GetStates(realmInstance);
        }

        public ICommand StatesOnLocal => new Command(() =>
        {
            _stateService.SaveStates(realmInstance, States.AsEnumerable().ToList());    
        });

        public override void Prepare(ObservableCollection<State> states)
        {
            States = states;
        }
        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
