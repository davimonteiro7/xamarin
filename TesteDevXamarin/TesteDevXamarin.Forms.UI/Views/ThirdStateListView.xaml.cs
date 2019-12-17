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
    public partial class ThirdStateListView : MvxContentPage<ThirdStateListViewModel>
    {
        public ThirdStateListView()
        {
            InitializeComponent();
        }

        private void RecordStatesButton_Clicked(object sender, EventArgs e)
        {
        }
    }
}