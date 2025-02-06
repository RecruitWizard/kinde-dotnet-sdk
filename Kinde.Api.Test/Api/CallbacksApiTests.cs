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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Kinde.Api.Client;
using Kinde.Api.Api;
// uncomment below to import models
//using Kinde.Api.Model;

namespace Kinde.Api.Test.Api
{
    /// <summary>
    ///  Class for testing CallbacksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallbacksApiTests : IDisposable
    {
        private CallbacksApi instance;

        public CallbacksApiTests()
        {
            instance = new CallbacksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallbacksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CallbacksApi
            //Assert.IsType<CallbacksApi>(instance);
        }

        /// <summary>
        /// Test AddLogoutRedirectURLs
        /// </summary>
        [Fact]
        public void AddLogoutRedirectURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //ReplaceLogoutRedirectURLsRequest replaceLogoutRedirectURLsRequest = null;
            //var response = instance.AddLogoutRedirectURLs(appId, replaceLogoutRedirectURLsRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test AddRedirectCallbackURLs
        /// </summary>
        [Fact]
        public void AddRedirectCallbackURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //ReplaceRedirectCallbackURLsRequest replaceRedirectCallbackURLsRequest = null;
            //var response = instance.AddRedirectCallbackURLs(appId, replaceRedirectCallbackURLsRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteCallbackURLs
        /// </summary>
        [Fact]
        public void DeleteCallbackURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string urls = null;
            //var response = instance.DeleteCallbackURLs(appId, urls);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteLogoutURLs
        /// </summary>
        [Fact]
        public void DeleteLogoutURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string urls = null;
            //var response = instance.DeleteLogoutURLs(appId, urls);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetCallbackURLs
        /// </summary>
        [Fact]
        public void GetCallbackURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetCallbackURLs(appId);
            //Assert.IsType<RedirectCallbackUrls>(response);
        }

        /// <summary>
        /// Test GetLogoutURLs
        /// </summary>
        [Fact]
        public void GetLogoutURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetLogoutURLs(appId);
            //Assert.IsType<LogoutRedirectUrls>(response);
        }

        /// <summary>
        /// Test ReplaceLogoutRedirectURLs
        /// </summary>
        [Fact]
        public void ReplaceLogoutRedirectURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //ReplaceLogoutRedirectURLsRequest replaceLogoutRedirectURLsRequest = null;
            //var response = instance.ReplaceLogoutRedirectURLs(appId, replaceLogoutRedirectURLsRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test ReplaceRedirectCallbackURLs
        /// </summary>
        [Fact]
        public void ReplaceRedirectCallbackURLsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //ReplaceRedirectCallbackURLsRequest replaceRedirectCallbackURLsRequest = null;
            //var response = instance.ReplaceRedirectCallbackURLs(appId, replaceRedirectCallbackURLsRequest);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
