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

       
        public void GetRegions()
        {
            Regions = new ObservableCollection<_Region>();
            foreach (var state in States)
            {
                if (!Regions.Any(r => r.Name == state.Region.Name))
                {
                    Regions.Add(new _Region()
                    { 
                        Name = state.Region.Name
                    });
                }
            }
        }

        public void FillRegions()
        {
            foreach (var region in Regions)
            {
                region.SetStatesOnRegion(States.ToList());
            }
        }
        public override void Prepare(ObservableCollection<State> states)
        {
            States = states;
            GetRegions();
            FillRegions();
        }
    }
}
