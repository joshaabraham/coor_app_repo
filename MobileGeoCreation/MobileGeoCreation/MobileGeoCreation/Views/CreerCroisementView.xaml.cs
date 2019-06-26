using MobileGeoCreation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileGeoCreation.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreerCroisementView : ContentPage
	{
        CreerCroisementViewModel viewModel;

        public CreerCroisementView ()
		{
			InitializeComponent ();
            BindingContext = this.viewModel = new CreerCroisementViewModel();
		}

      
      
	}
}
 