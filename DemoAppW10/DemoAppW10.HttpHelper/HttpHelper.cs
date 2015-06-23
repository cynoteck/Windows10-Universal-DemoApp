using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DemoAppW10.Common.Interface;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;

namespace DemoAppW10.HttpHelper
{
    public class HttpHelper : IHelper
    {
        public HttpHelper()
        {
            // TODO: Complete member initialization
        }

        public bool IsInternet()
        {
            bool isInternetConnectionAvailable = false;

            ConnectionProfile InternetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();
            if (InternetConnectionProfile != null && InternetConnectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess)
            {
                isInternetConnectionAvailable = true;
            }

            return isInternetConnectionAvailable;
        }

        public async Task<string> Get(string url)
        {
            try
            {
                string content = string.Empty;

                var httpClient = new HttpClient();

                var httpResponse = await httpClient.GetStringAsync(url);

                return httpResponse;
            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        public async Task ShowMessage(string messageText, string messageHeader)
        {
            MessageDialog msg = new MessageDialog(messageText, messageHeader);
            await msg.ShowAsync();
        }
    }
}
