using Intrinio.Net.Client;
using Intrinio.Net.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Intrinio.Net.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkDownloadsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Links
        /// </summary>
        /// <remarks>
        /// Returns all active bulk downloads for your account with links to download.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseBulkDownloadLinks</returns>
        ApiResponseBulkDownloadLinks GetBulkDownloadLinks ();

        /// <summary>
        /// All Links
        /// </summary>
        /// <remarks>
        /// Returns all active bulk downloads for your account with links to download.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseBulkDownloadLinks</returns>
        ApiResponse<ApiResponseBulkDownloadLinks> GetBulkDownloadLinksWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Links
        /// </summary>
        /// <remarks>
        /// Returns all active bulk downloads for your account with links to download.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseBulkDownloadLinks</returns>
        System.Threading.Tasks.Task<ApiResponseBulkDownloadLinks> GetBulkDownloadLinksAsync ();

        /// <summary>
        /// All Links
        /// </summary>
        /// <remarks>
        /// Returns all active bulk downloads for your account with links to download.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseBulkDownloadLinks)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseBulkDownloadLinks>> GetBulkDownloadLinksAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BulkDownloadsApi : IBulkDownloadsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDownloadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkDownloadsApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDownloadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BulkDownloadsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// All Links Returns all active bulk downloads for your account with links to download.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseBulkDownloadLinks</returns>
        public ApiResponseBulkDownloadLinks GetBulkDownloadLinks ()
        {
             ApiResponse<ApiResponseBulkDownloadLinks> localVarResponse = GetBulkDownloadLinksWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Links Returns all active bulk downloads for your account with links to download.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseBulkDownloadLinks</returns>


        public ApiResponse< ApiResponseBulkDownloadLinks > GetBulkDownloadLinksWithHttpInfo ()
        {

            var localVarPath = "/bulk_downloads/links";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBulkDownloadLinks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseBulkDownloadLinks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseBulkDownloadLinks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseBulkDownloadLinks)));
        }

        /// <summary>
        /// All Links Returns all active bulk downloads for your account with links to download.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseBulkDownloadLinks</returns>
        public async System.Threading.Tasks.Task<ApiResponseBulkDownloadLinks> GetBulkDownloadLinksAsync ()
        {
             ApiResponse<ApiResponseBulkDownloadLinks> localVarResponse = await GetBulkDownloadLinksAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Links Returns all active bulk downloads for your account with links to download.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseBulkDownloadLinks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseBulkDownloadLinks>> GetBulkDownloadLinksAsyncWithHttpInfo ()
        {

            var localVarPath = "/bulk_downloads/links";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              


            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBulkDownloadLinks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseBulkDownloadLinks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseBulkDownloadLinks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseBulkDownloadLinks)));
        }

    }
}
