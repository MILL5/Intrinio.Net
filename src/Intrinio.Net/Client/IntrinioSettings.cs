namespace Intrinio.Net
{
    public class IntrinioSettings
    {
        private const string INTRINIO_HTTPCLIENT_NAME = "IntrinioHttpClient";

        internal string ApiKey { get; set; }

        public static string HttpClientName => INTRINIO_HTTPCLIENT_NAME;
    }
}