/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEnvelopePurgeConfigurationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Select envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns></returns>
        EnvelopePurgeConfiguration GetEnvelopePurgeConfiguration (string accountId);

        /// <summary>
        /// Select envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>ApiResponse of </returns>
        ApiResponse<EnvelopePurgeConfiguration> GetEnvelopePurgeConfigurationWithHttpInfo (string accountId);
        /// <summary>
        /// Updates envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns></returns>
        EnvelopePurgeConfiguration UpdateEnvelopePurgeConfiguration (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null);

        /// <summary>
        /// Updates envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>ApiResponse of </returns>
        ApiResponse<EnvelopePurgeConfiguration> UpdateEnvelopePurgeConfigurationWithHttpInfo (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Select envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>Task of EnvelopePurgeConfiguration</returns>
        System.Threading.Tasks.Task<EnvelopePurgeConfiguration> GetEnvelopePurgeConfigurationAsync (string accountId);

        /// <summary>
        /// Select envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>Task of ApiResponse (EnvelopePurgeConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopePurgeConfiguration>> GetEnvelopePurgeConfigurationAsyncWithHttpInfo (string accountId);
        /// <summary>
        /// Updates envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>Task of EnvelopePurgeConfiguration</returns>
        System.Threading.Tasks.Task<EnvelopePurgeConfiguration> UpdateEnvelopePurgeConfigurationAsync (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null);

        /// <summary>
        /// Updates envelope purge configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>Task of ApiResponse (EnvelopePurgeConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopePurgeConfiguration>> UpdateEnvelopePurgeConfigurationAsyncWithHttpInfo (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EnvelopePurgeConfigurationApi : IEnvelopePurgeConfigurationApi
    {
        private DocuSign.eSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopePurgeConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnvelopePurgeConfigurationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = DocuSign.eSign.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopePurgeConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EnvelopePurgeConfigurationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = DocuSign.eSign.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public DocuSign.eSign.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Select envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>EnvelopePurgeConfiguration</returns>
        public EnvelopePurgeConfiguration GetEnvelopePurgeConfiguration (string accountId)
        {
             ApiResponse<EnvelopePurgeConfiguration> localVarResponse = GetEnvelopePurgeConfigurationWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Select envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>ApiResponse of EnvelopePurgeConfiguration</returns>
        public ApiResponse< EnvelopePurgeConfiguration > GetEnvelopePurgeConfigurationWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling EnvelopePurgeConfigurationApi->GetEnvelopePurgeConfiguration");

            var localVarPath = "/v2.1/accounts/{accountId}/settings/envelope_purge_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter




            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEnvelopePurgeConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(EnvelopePurgeConfiguration)));
            }
            else
            {
                return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnvelopePurgeConfiguration)));
            }
            
        }

        /// <summary>
        /// Select envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>Task of EnvelopePurgeConfiguration</returns>
        public async System.Threading.Tasks.Task<EnvelopePurgeConfiguration> GetEnvelopePurgeConfigurationAsync (string accountId)
        {
             ApiResponse<EnvelopePurgeConfiguration> localVarResponse = await GetEnvelopePurgeConfigurationAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Select envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        
        
        /// <returns>Task of ApiResponse (EnvelopePurgeConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopePurgeConfiguration>> GetEnvelopePurgeConfigurationAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling EnvelopePurgeConfigurationApi->GetEnvelopePurgeConfiguration");

            var localVarPath = "/v2.1/accounts/{accountId}/settings/envelope_purge_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter




            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEnvelopePurgeConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnvelopePurgeConfiguration)));
            
        }



        /// <summary>
        /// Updates envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>EnvelopePurgeConfiguration</returns>
        public EnvelopePurgeConfiguration UpdateEnvelopePurgeConfiguration (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null)
        {
             ApiResponse<EnvelopePurgeConfiguration> localVarResponse = UpdateEnvelopePurgeConfigurationWithHttpInfo(accountId, envelopePurgeConfiguration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>ApiResponse of EnvelopePurgeConfiguration</returns>
        public ApiResponse< EnvelopePurgeConfiguration > UpdateEnvelopePurgeConfigurationWithHttpInfo (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling EnvelopePurgeConfigurationApi->UpdateEnvelopePurgeConfiguration");

            var localVarPath = "/v2.1/accounts/{accountId}/settings/envelope_purge_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            if (envelopePurgeConfiguration != null && envelopePurgeConfiguration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(envelopePurgeConfiguration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = envelopePurgeConfiguration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateEnvelopePurgeConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(EnvelopePurgeConfiguration)));
            }
            else
            {
                return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnvelopePurgeConfiguration)));
            }
            
        }

        /// <summary>
        /// Updates envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>Task of EnvelopePurgeConfiguration</returns>
        public async System.Threading.Tasks.Task<EnvelopePurgeConfiguration> UpdateEnvelopePurgeConfigurationAsync (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null)
        {
             ApiResponse<EnvelopePurgeConfiguration> localVarResponse = await UpdateEnvelopePurgeConfigurationAsyncWithHttpInfo(accountId, envelopePurgeConfiguration);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates envelope purge configuration. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="envelopePurgeConfiguration"> (optional)</param>
        
        /// <returns>Task of ApiResponse (EnvelopePurgeConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopePurgeConfiguration>> UpdateEnvelopePurgeConfigurationAsyncWithHttpInfo (string accountId, EnvelopePurgeConfiguration envelopePurgeConfiguration = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling EnvelopePurgeConfigurationApi->UpdateEnvelopePurgeConfiguration");

            var localVarPath = "/v2.1/accounts/{accountId}/settings/envelope_purge_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            if (envelopePurgeConfiguration != null && envelopePurgeConfiguration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(envelopePurgeConfiguration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = envelopePurgeConfiguration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateEnvelopePurgeConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EnvelopePurgeConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopePurgeConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnvelopePurgeConfiguration)));
            
        }

    }
}
