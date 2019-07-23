using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncidentList : ContentPage
	{
		public IncidentList ()
		{
			InitializeComponent ();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateIncident());
        }
    }
}