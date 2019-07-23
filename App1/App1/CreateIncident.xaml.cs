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
	public partial class CreateIncident : ContentPage
	{
		public CreateIncident ()
		{
			InitializeComponent ();
		}
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // TEST SERVER CONNECTION
            // PUSH TO API
            // IF 200 THEN ATTEMPT TO PUSH ALL LOCAL INCIDENTS TO API
            // CLEAR LOCAL DB? OR UPDATE ALL SUCCESSFULL INCIDENTS WITH A DATETIMESTAMP?
            await Navigation.PushModalAsync(new IncidentList());
        }
        async void OnCancelButtonClicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new MainPage());
        }
    }
}