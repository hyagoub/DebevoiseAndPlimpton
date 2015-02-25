using System.Configuration;

namespace DebevoiseAndPlimpton
{
    public class Constants
    {
        /// <summary>
        /// OAuth EndPoints.
        /// </summary>
        public static class OauthEndPoints
        {
            /// <summary>
            /// Url Request Token
            /// </summary>
            public static string UrlRequestToken = ConfigurationManager.AppSettings["Url_Request_Token"] != null ?
                ConfigurationManager.AppSettings["Url_Request_Token"].ToString() : "/get_request_token";

            /// <summary>
            /// Url Access Token
            /// </summary>
            public static string UrlAccessToken = ConfigurationManager.AppSettings["Url_Access_Token"] != null ?
                ConfigurationManager.AppSettings["Url_Access_Token"].ToString() : "/get_access_token";

            /// <summary>
            /// Federation base url.
            /// </summary>
            public static string IdFedOAuthBaseUrl = ConfigurationManager.AppSettings["Intuit_OAuth_BaseUrl"] != null ?
                ConfigurationManager.AppSettings["Intuit_OAuth_BaseUrl"].ToString() : "https://oauth.intuit.com/oauth/v1";

            /// <summary>
            /// Authorize url.
            /// </summary>
            public static string AuthorizeUrl = ConfigurationManager.AppSettings["Intuit_Workplace_AuthorizeUrl"] != null ?
                ConfigurationManager.AppSettings["Intuit_Workplace_AuthorizeUrl"].ToString() : "https://workplace.intuit.com/Connect/Begin";
        }

        /// <summary>
        /// IPP Platform Endpoints
        /// </summary>
        public static class IppEndPoints
        {
            /// <summary>
            /// Disconnect url.
            /// </summary>
            public static string DisconnectUrl = ConfigurationManager.AppSettings["DisconnectUrl"] != null ?
                ConfigurationManager.AppSettings["DisconnectUrl"].ToString() : "https://appcenter.intuit.com/api/v1/Connection/Disconnect";
        }
    }
}