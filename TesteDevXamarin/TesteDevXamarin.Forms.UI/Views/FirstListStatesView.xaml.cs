using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TesteDevXamarin.Core.Models.Domain;
using TesteDevXamarin.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDevXamarin.Forms.UI.Views
{
  
    public partial class FirstListStatesView : MvxContentPage<FirstStateListViewModel>
    {
        public FirstListStatesView()
        {
            InitializeComponent();
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            statesListView.IsVisible = false;
            searchResults.IsVisible = true;
        }
    }
}
