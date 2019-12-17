using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TesteDevXamarin.Core.Models.Domain;
using TesteDevXamarin.Core.Models.Domain.Services;
using Xamarin.Forms;
using System.Linq;


namespace TesteDevXamarin.Core.ViewModels
{
    public class SecondStateListViewModel : MvxViewModel <ObservableCollection<State>>
    {
        
        public ObservableCollection<State> States { get; set; }
        
        private ObservableCollection<_Region> _regions;
        public ObservableCollection<_Region> Regions {
            get {
                return _regions;
            }
            set {
                _regions = value;
                RaisePropertyChanged();
            }
        }

        public override void Prepare(ObservableCollection<State> states)
        {
            States = states;
            GetRegions();
        }

        public void GetRegions()
        {
            Regions = new ObservableCollection<_Region>();            
            foreach (var state in States)
            {
                if (!Regions.Any(r => r.Name == state.Region.Name))
                {
                    var statesByRegion = GetStatesByRegion(state.Region.Name);
                    Regions.Add(new _Region(statesByRegion)
                    { 
                        Name = state.Region.Name,
                    });
                }
            }
        }

        private List<State> GetStatesByRegion(string regionName)
        {
            var states = States.Where(s => s.Region.Name == regionName).ToList();
            return states;
        }
    }
}
