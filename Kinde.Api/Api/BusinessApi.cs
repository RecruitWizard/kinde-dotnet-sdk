/*
 * Kinde Management API
 *
 *  Provides endpoints to manage your Kinde Businesses.  ## Intro  ## How to use  1. [Set up and authorize a machine-to-machine (M2M) application](https://docs.kinde.com/developer-tools/kinde-api/connect-to-kinde-api/).  2. [Generate a test access token](https://docs.kinde.com/developer-tools/kinde-api/access-token-for-api/)  3. Test request any endpoint using the test token 
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Kinde.Api.Client;
using Kinde.Api.Model;

namespace Kinde.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBusinessApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get business
        /// </summary>
        /// <remarks>
        /// Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetBusinessResponse</returns>
        GetBusinessResponse GetBusiness();

        /// <summary>
        /// Get business
        /// </summary>
        /// <remarks>
        /// Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetBusinessResponse</returns>
        ApiResponse<GetBusinessResponse> GetBusinessWithHttpInfo();
        /// <summary>
        /// Update business
        /// </summary>
        /// <remarks>
        /// Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse UpdateBusiness(UpdateBusinessRequest updateBusinessRequest);

        /// <summary>
        /// Update business
        /// </summary>
        /// <remarks>
        /// Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> UpdateBusinessWithHttpInfo(UpdateBusinessRequest updateBusinessRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBusinessApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get business
        /// </summary>
        /// <remarks>
        /// Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetBusinessResponse</returns>
        System.Threading.Tasks.Task<GetBusinessResponse> GetBusinessAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get business
        /// </summary>
        /// <remarks>
        /// Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetBusinessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetBusinessResponse>> GetBusinessWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update business
        /// </summary>
        /// <remarks>
        /// Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> UpdateBusinessAsync(UpdateBusinessRequest updateBusinessRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update business
        /// </summary>
        /// <remarks>
        /// Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </remarks>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> UpdateBusinessWithHttpInfoAsync(UpdateBusinessRequest updateBusinessRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBusinessApi : IBusinessApiSync, IBusinessApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BusinessApi : IDisposable, IBusinessApi
    {
        private Kinde.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public BusinessApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public BusinessApi(string basePath)
        {
            this.Configuration = Kinde.Api.Client.Configuration.MergeConfigurations(
                Kinde.Api.Client.GlobalConfiguration.Instance,
                new Kinde.Api.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Kinde.Api.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public BusinessApi(Kinde.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Kinde.Api.Client.Configuration.MergeConfigurations(
                Kinde.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Kinde.Api.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BusinessApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BusinessApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Kinde.Api.Client.Configuration.MergeConfigurations(
                Kinde.Api.Client.GlobalConfiguration.Instance,
                new Kinde.Api.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Kinde.Api.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BusinessApi(HttpClient client, Kinde.Api.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Kinde.Api.Client.Configuration.MergeConfigurations(
                Kinde.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Kinde.Api.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BusinessApi(Kinde.Api.Client.ISynchronousClient client, Kinde.Api.Client.IAsynchronousClient asyncClient, Kinde.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessApi"/> class
        /// using a client instance.
        /// </summary>
        /// <param name="client">The client API</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BusinessApi(Kinde.Api.Client.ApiClient client)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Client = client;
            this.AsynchronousClient = client;
            this.Configuration = Kinde.Api.Client.GlobalConfiguration.Instance;
            this.ExceptionFactory = Kinde.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Kinde.Api.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Kinde.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Kinde.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Kinde.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Kinde.Api.Client.ExceptionFactory ExceptionFactory
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
        /// Get business Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetBusinessResponse</returns>
        public GetBusinessResponse GetBusiness()
        {
            Kinde.Api.Client.ApiResponse<GetBusinessResponse> localVarResponse = GetBusinessWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get business Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetBusinessResponse</returns>
        public Kinde.Api.Client.ApiResponse<GetBusinessResponse> GetBusinessWithHttpInfo()
        {
            Kinde.Api.Client.RequestOptions localVarRequestOptions = new Kinde.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kinde.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Kinde.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (kindeBearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetBusinessResponse>("/api/v1/business", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBusiness", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get business Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetBusinessResponse</returns>
        public async System.Threading.Tasks.Task<GetBusinessResponse> GetBusinessAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Kinde.Api.Client.ApiResponse<GetBusinessResponse> localVarResponse = await GetBusinessWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get business Get your business details.  &lt;div&gt;   &lt;code&gt;read:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetBusinessResponse)</returns>
        public async System.Threading.Tasks.Task<Kinde.Api.Client.ApiResponse<GetBusinessResponse>> GetBusinessWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Kinde.Api.Client.RequestOptions localVarRequestOptions = new Kinde.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Kinde.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Kinde.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (kindeBearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<GetBusinessResponse>("/api/v1/business", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBusiness", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update business Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse UpdateBusiness(UpdateBusinessRequest updateBusinessRequest)
        {
            Kinde.Api.Client.ApiResponse<SuccessResponse> localVarResponse = UpdateBusinessWithHttpInfo(updateBusinessRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update business Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public Kinde.Api.Client.ApiResponse<SuccessResponse> UpdateBusinessWithHttpInfo(UpdateBusinessRequest updateBusinessRequest)
        {
            // verify the required parameter 'updateBusinessRequest' is set
            if (updateBusinessRequest == null)
                throw new Kinde.Api.Client.ApiException(400, "Missing required parameter 'updateBusinessRequest' when calling BusinessApi->UpdateBusiness");

            Kinde.Api.Client.RequestOptions localVarRequestOptions = new Kinde.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kinde.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Kinde.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = updateBusinessRequest;

            // authentication (kindeBearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<SuccessResponse>("/api/v1/business", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateBusiness", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update business Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> UpdateBusinessAsync(UpdateBusinessRequest updateBusinessRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Kinde.Api.Client.ApiResponse<SuccessResponse> localVarResponse = await UpdateBusinessWithHttpInfoAsync(updateBusinessRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update business Update your business details.  &lt;div&gt;   &lt;code&gt;update:businesses&lt;/code&gt; &lt;/div&gt; 
        /// </summary>
        /// <exception cref="Kinde.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateBusinessRequest">The business details to update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<Kinde.Api.Client.ApiResponse<SuccessResponse>> UpdateBusinessWithHttpInfoAsync(UpdateBusinessRequest updateBusinessRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'updateBusinessRequest' is set
            if (updateBusinessRequest == null)
                throw new Kinde.Api.Client.ApiException(400, "Missing required parameter 'updateBusinessRequest' when calling BusinessApi->UpdateBusiness");


            Kinde.Api.Client.RequestOptions localVarRequestOptions = new Kinde.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Kinde.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Kinde.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = updateBusinessRequest;

            // authentication (kindeBearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<SuccessResponse>("/api/v1/business", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateBusiness", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}