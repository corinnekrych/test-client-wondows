using FHSDK;
using FHSDK.FHHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InstantSupportApp.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Feed_hendry : Page
    {
        public Feed_hendry()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                bool inited = await FHClient.Init();
                var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
                var data = new Dictionary<string, object> { { "emailId", "user1@demo.com" } };
                var response = await FH.Cloud("/userDetails", "GET", headers, data);
                if (response.Error == null)
                {
                    // Response.Text = (string)response.GetResponseAsDictionary()["msg"];
                    // FirePropertyChanged("Response");
                }
                else
                {
                    //await new MessageDialog(response.Error.Message).ShowAsync();
                }
            }

            catch (FHException ex)
            {
                string str = ex.Message;
            }

        }
    }
}
