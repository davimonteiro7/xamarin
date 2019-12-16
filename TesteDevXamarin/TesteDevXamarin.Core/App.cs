using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDevXamarin.Core.Models.Domain.Services;
using TesteDevXamarin.Core.ViewModels;

namespace TesteDevXamarin.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IStateService, StateService>();
            RegisterAppStart<FirstStateListViewModel>();
        }
    }
}
