namespace Intrinio.Net.Client
{
    public class IntrinioSettings
    {
        private const string INTRINIO_API_BASE_URL = "https://api-v2.intrinio.com";
        
        private const string INTRINIO_HTTPCLIENT_NAME = "IntrinioHttpClient";

        public string ApiBaseUrl => INTRINIO_API_BASE_URL;

        public string ApiKey { get; set; }

        public string HttpClientName => INTRINIO_HTTPCLIENT_NAME;
    }
}