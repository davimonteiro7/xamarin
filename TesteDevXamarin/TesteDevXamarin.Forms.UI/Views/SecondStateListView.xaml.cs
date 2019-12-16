using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDevXamarin.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDevXamarin.Forms.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondStateListView : MvxContentPage<SecondStateListViewModel>
    {
        public SecondStateListView()
        {
            InitializeComponent();
        }
    }
}