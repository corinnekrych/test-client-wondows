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

namespace InstantSupportApp.UWP
{
    public sealed partial class MainPage
    {


        public MainPage()
        {
            InitializeComponent();

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            try {
                bool inited = await FHClient.Init();
                // UpdateuserProfile();
                 //CreateCAllBackRequest();
                // updateTechStatus();
                //GetUserDetails();
                // getTechList();
                //  getAllTickets();
               // getVIPRequestStatus();


            }
    
            catch (FHException ex)
            {
                string str = ex.Message;
}
           
        }
        //Not working
        public async void GetUserDetails()
        {
            Object emailId = "tony.bedard@hpe.com";
            //.Replace("\"",string.Empty )
            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
          //  var data = new Dictionary<string, object> { { "emailId", emailTxt.Text} };
            //var data1 = new Dictionary<string, object> { { "companyId", "1" } , { "countryCode", "US" } };
            //string json = JsonConvert.SerializeObject(data1);
            //EmailID email = new EmailID();
            //email.emailId = "ameet.kumar-mandal@hpe.com";
            //string json = JsonConvert.SerializeObject(email);
            //var data = "{ "emailId":"ameet.kumar-mandal@hpe.com" }";
           // var response = await FH.Cloud("/userDetails ", "GET", headers, data);
            // var response = await FH.Cloud("/getAllCompanies", "GET", null, null);
            // var response = await FH.Cloud("getAllITSupportLocations", "GET", headers, data);
            //if (response.Error == null)
            //{
            //    // Response.Text = (string)response.GetResponseAsDictionary()["msg"];
            //    // FirePropertyChanged("Response");
            //}
            //else
            //{
            //    //await new MessageDialog(response.Error.Message).ShowAsync();
            //}
        }
        //working
        public async void UpdateuserProfile()
        {

            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "emailId", "nikunj.patel@hpe.com" }, { "type", "1" }, { "primaryPhoneNum", "01-789456155 " }, { "secondaryPhoneNum1", "01-2583688888 " }, { "secondaryPhoneNum2", "" }, { "userSelectedLang", "en"} };
            var response = await FH.Cloud("/updateUserProfile ", "POST", headers, data);
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
        public async void getTechList()
        {

            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "emailId", "tech1@demo.com" }, { "countryCode", "US" }, { "companyId", "1" } };
            var response = await FH.Cloud("/getTechList", "GET", headers, data);
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
        
        public async void getAllTickets()
        {

            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "assigneeTechId", "tech1@demo.com" },  { "companyId", "1" } };
            var response = await FH.Cloud("/getAllTickets", "GET", headers, data);
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
        public async void getVIPRequestStatus()
        {

            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "emailId", "tech1@demo.com" }, { "companyId", "1" } };
            var response = await FH.Cloud("/getVIPRequestStatus ", "GET", headers, data);
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
        //Not working
        public async void CreateCAllBackRequest()
        {
            
            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "emailId", "tony.bedard@hpe.com" }, { "userType", "1" }, { "phoneNumber", "01-789456155 " }, { "callQueueId", "1" }, { "companyId", "1" }, { "questionId", "3" }, { "vdnNum", "7131251" }, { "primaryAddress", "http://16.153.198.39:8081/webcallback/WebCallback418?wsdl" }, { "secondaryAddress", "http://16.153.198.39:8081/webcallback/WebCallback418?wsdl" } };
            var response = await FH.Cloud("/createCallBackRequest", "POST", headers, data);
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
        //working
        public async void updateTechStatus()
        {
            var headers = new Dictionary<string, string> { { "contentType", "application/json" } };
            var data = new Dictionary<string, object> { { "emailId", "tech1@demo.com" }, { "companyId", "1" } };

            var response = await FH.Cloud("/updateTechStatus", "POST", headers, data);
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

        public class EmailID
        {
            public string emailId { get; set; }
            //   public object Id { get; set; }

        }

        private void WindowsPage_Loaded(object sender, RoutedEventArgs e)
        {
            GetUserDetails();
        }
    }
}