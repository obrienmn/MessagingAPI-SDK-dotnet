/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace com.telstra.messaging.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProvisioningApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Subscription
        /// </summary>
        /// <remarks>
        /// Provision a mobile number
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>ProvisionNumberResponse</returns>
        ProvisionNumberResponse CreateSubscription (ProvisionNumberRequest body);

        /// <summary>
        /// Create Subscription
        /// </summary>
        /// <remarks>
        /// Provision a mobile number
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>ApiResponse of ProvisionNumberResponse</returns>
        ApiResponse<ProvisionNumberResponse> CreateSubscriptionWithHttpInfo (ProvisionNumberRequest body);
        /// <summary>
        /// Delete Subscription
        /// </summary>
        /// <remarks>
        /// Delete a mobile number subscription from an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns></returns>
        void DeleteSubscription (DeleteNumberRequest body);

        /// <summary>
        /// Delete Subscription
        /// </summary>
        /// <remarks>
        /// Delete a mobile number subscription from an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSubscriptionWithHttpInfo (DeleteNumberRequest body);
        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// Get mobile number subscription for an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetSubscriptionResponse</returns>
        GetSubscriptionResponse GetSubscription ();

        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// Get mobile number subscription for an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetSubscriptionResponse</returns>
        ApiResponse<GetSubscriptionResponse> GetSubscriptionWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Subscription
        /// </summary>
        /// <remarks>
        /// Provision a mobile number
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>Task of ProvisionNumberResponse</returns>
        System.Threading.Tasks.Task<ProvisionNumberResponse> CreateSubscriptionAsync (ProvisionNumberRequest body);

        /// <summary>
        /// Create Subscription
        /// </summary>
        /// <remarks>
        /// Provision a mobile number
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>Task of ApiResponse (ProvisionNumberResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProvisionNumberResponse>> CreateSubscriptionAsyncWithHttpInfo (ProvisionNumberRequest body);
        /// <summary>
        /// Delete Subscription
        /// </summary>
        /// <remarks>
        /// Delete a mobile number subscription from an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSubscriptionAsync (DeleteNumberRequest body);

        /// <summary>
        /// Delete Subscription
        /// </summary>
        /// <remarks>
        /// Delete a mobile number subscription from an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSubscriptionAsyncWithHttpInfo (DeleteNumberRequest body);
        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// Get mobile number subscription for an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetSubscriptionResponse</returns>
        System.Threading.Tasks.Task<GetSubscriptionResponse> GetSubscriptionAsync ();

        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// Get mobile number subscription for an account
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetSubscriptionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetSubscriptionResponse>> GetSubscriptionAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProvisioningApi : IProvisioningApi
    {
        private com.telstra.messaging.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProvisioningApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProvisioningApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
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
        public com.telstra.messaging.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create Subscription Provision a mobile number
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>ProvisionNumberResponse</returns>
        public ProvisionNumberResponse CreateSubscription (ProvisionNumberRequest body)
        {
             ApiResponse<ProvisionNumberResponse> localVarResponse = CreateSubscriptionWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Subscription Provision a mobile number
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>ApiResponse of ProvisionNumberResponse</returns>
        public ApiResponse< ProvisionNumberResponse > CreateSubscriptionWithHttpInfo (ProvisionNumberRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProvisioningApi->CreateSubscription");

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProvisionNumberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProvisionNumberResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvisionNumberResponse)));
        }

        /// <summary>
        /// Create Subscription Provision a mobile number
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>Task of ProvisionNumberResponse</returns>
        public async System.Threading.Tasks.Task<ProvisionNumberResponse> CreateSubscriptionAsync (ProvisionNumberRequest body)
        {
             ApiResponse<ProvisionNumberResponse> localVarResponse = await CreateSubscriptionAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Subscription Provision a mobile number
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A JSON payload containing the required attributes</param>
        /// <returns>Task of ApiResponse (ProvisionNumberResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProvisionNumberResponse>> CreateSubscriptionAsyncWithHttpInfo (ProvisionNumberRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProvisioningApi->CreateSubscription");

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProvisionNumberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProvisionNumberResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvisionNumberResponse)));
        }

        /// <summary>
        /// Delete Subscription Delete a mobile number subscription from an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns></returns>
        public void DeleteSubscription (DeleteNumberRequest body)
        {
             DeleteSubscriptionWithHttpInfo(body);
        }

        /// <summary>
        /// Delete Subscription Delete a mobile number subscription from an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSubscriptionWithHttpInfo (DeleteNumberRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProvisioningApi->DeleteSubscription");

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Subscription Delete a mobile number subscription from an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSubscriptionAsync (DeleteNumberRequest body)
        {
             await DeleteSubscriptionAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Delete Subscription Delete a mobile number subscription from an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmptyArr</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSubscriptionAsyncWithHttpInfo (DeleteNumberRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProvisioningApi->DeleteSubscription");

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Subscription Get mobile number subscription for an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetSubscriptionResponse</returns>
        public GetSubscriptionResponse GetSubscription ()
        {
             ApiResponse<GetSubscriptionResponse> localVarResponse = GetSubscriptionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Subscription Get mobile number subscription for an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetSubscriptionResponse</returns>
        public ApiResponse< GetSubscriptionResponse > GetSubscriptionWithHttpInfo ()
        {

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetSubscriptionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetSubscriptionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetSubscriptionResponse)));
        }

        /// <summary>
        /// Get Subscription Get mobile number subscription for an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetSubscriptionResponse</returns>
        public async System.Threading.Tasks.Task<GetSubscriptionResponse> GetSubscriptionAsync ()
        {
             ApiResponse<GetSubscriptionResponse> localVarResponse = await GetSubscriptionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Subscription Get mobile number subscription for an account
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetSubscriptionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetSubscriptionResponse>> GetSubscriptionAsyncWithHttpInfo ()
        {

            var localVarPath = "/messages/provisioning/subscriptions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetSubscriptionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetSubscriptionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetSubscriptionResponse)));
        }

    }
}
