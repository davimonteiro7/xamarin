using MvvmCross;
using MvvmCross.ViewModels;
using TesteDevXamarin.Core.Models.Domain.Repositories;
using TesteDevXamarin.Core.Models.Domain.Services;
using TesteDevXamarin.Core.ViewModels;
using TTesteDevXamarin.Core.Models.Data.Persistence.Repositories;

namespace TesteDevXamarin.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IStateService, StateService>();
            Mvx.IoCProvider.RegisterType<IStateRepository, StateRepository>();
            
            RegisterAppStart<FirstStateListViewModel>();
        }
    }
}
