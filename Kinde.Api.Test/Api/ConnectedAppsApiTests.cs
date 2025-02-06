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
    ///  Class for testing ConnectedAppsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConnectedAppsApiTests : IDisposable
    {
        private ConnectedAppsApi instance;

        public ConnectedAppsApiTests()
        {
            instance = new ConnectedAppsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConnectedAppsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConnectedAppsApi
            //Assert.IsType<ConnectedAppsApi>(instance);
        }

        /// <summary>
        /// Test GetConnectedAppAuthUrl
        /// </summary>
        [Fact]
        public void GetConnectedAppAuthUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyCodeRef = null;
            //string? userId = null;
            //string? orgCode = null;
            //string? overrideCallbackUrl = null;
            //var response = instance.GetConnectedAppAuthUrl(keyCodeRef, userId, orgCode, overrideCallbackUrl);
            //Assert.IsType<ConnectedAppsAuthUrl>(response);
        }

        /// <summary>
        /// Test GetConnectedAppToken
        /// </summary>
        [Fact]
        public void GetConnectedAppTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sessionId = null;
            //var response = instance.GetConnectedAppToken(sessionId);
            //Assert.IsType<ConnectedAppsAccessToken>(response);
        }

        /// <summary>
        /// Test RevokeConnectedAppToken
        /// </summary>
        [Fact]
        public void RevokeConnectedAppTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sessionId = null;
            //var response = instance.RevokeConnectedAppToken(sessionId);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
