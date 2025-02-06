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
    ///  Class for testing OAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OAuthApiTests : IDisposable
    {
        private OAuthApi instance;

        public OAuthApiTests()
        {
            instance = new OAuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OAuthApi
            //Assert.IsType<OAuthApi>(instance);
        }

        /// <summary>
        /// Test GetUserProfileV2
        /// </summary>
        [Fact]
        public void GetUserProfileV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserProfileV2();
            //Assert.IsType<UserProfileV2>(response);
        }

        /// <summary>
        /// Test TokenIntrospection
        /// </summary>
        [Fact]
        public void TokenIntrospectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string? tokenTypeHint = null;
            //var response = instance.TokenIntrospection(token, tokenTypeHint);
            //Assert.IsType<TokenIntrospect>(response);
        }

        /// <summary>
        /// Test TokenRevocation
        /// </summary>
        [Fact]
        public void TokenRevocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string token = null;
            //string? clientSecret = null;
            //string? tokenTypeHint = null;
            //instance.TokenRevocation(clientId, token, clientSecret, tokenTypeHint);
        }
    }
}
