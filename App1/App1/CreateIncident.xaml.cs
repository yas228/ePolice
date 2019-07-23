using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateIncident : ContentPage
	{
        string text_ip = "192.168.1.1";
        public string reply_status = "";

		public CreateIncident ()
		{
			InitializeComponent ();
		}
        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            #region TEST SERVER CONNECTION 
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(text_ip, timeout, buffer, options);            
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
            #endregion

            #region PUSH TO API
            #endregion

            // IF 200 THEN ATTEMPT TO PUSH ALL LOCAL INCIDENTS TO API
            // CLEAR LOCAL DB? OR UPDATE ALL SUCCESSFULL INCIDENTS WITH A DATETIMESTAMP?
            
            // Move to IncidentList Page
            //await Navigation.PushModalAsync(new IncidentList());
        }
        async void OnCancelButtonClicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new MainPage());
        }
    }
}