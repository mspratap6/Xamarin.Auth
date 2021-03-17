using System;
using System.Threading.Tasks;

using Android.Locations;
using Android.Webkit;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth
#else
namespace Xamarin.Auth._MobileServices
#endif
{
    /// <summary>
    /// Web view configuration.
    /// </summary>
    public static class WebViewConfiguration
    {
        public static class Android
        {
            public static string UserAgent
            {
                get;
                set;
            }

            static Android()
            {
                UserAgent = "Mozilla/5.0 (Android; Tablet; rv:20.0) Gecko/20.0 Firefox/20.0";

                //var webSettings = (new WebView(global::Android.App.Application.Context)).Settings;
                //if (webSettings != null)
                //    UserAgent = webSettings.UserAgentString;

                return;
            }

        }
    }
}
