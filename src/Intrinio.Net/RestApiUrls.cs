namespace Intrinio.Net
{
    public static class RestApiUrls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "need to use const to build Urls")]
        public const string BASE_URL = "https://api-v2.intrinio.com";

        public static class Company
        {
            public const string Default = BASE_URL + "/companies";
            public const string Lookup = Default + "/{0}";
        }

        public static class Exchanges
        {
            public const string Default = BASE_URL + "/stock_exchanges";
            public const string SecuritiesByExchange = Default + "/{0}/securities";
            public const string PricesByExchange = Default + "/{0}/prices";
        }

        public static class Securities
        {
            public const string Default = BASE_URL + "/securities";
        }

        public static class Prices
        {
            public const string Default = BASE_URL + "/securities";
            public const string BySecurity = Default + "/{0}/prices";
        }
    }
}