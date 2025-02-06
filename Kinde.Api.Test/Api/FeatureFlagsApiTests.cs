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
    ///  Class for testing FeatureFlagsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FeatureFlagsApiTests : IDisposable
    {
        private FeatureFlagsApi instance;

        public FeatureFlagsApiTests()
        {
            instance = new FeatureFlagsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FeatureFlagsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FeatureFlagsApi
            //Assert.IsType<FeatureFlagsApi>(instance);
        }

        /// <summary>
        /// Test CreateFeatureFlag
        /// </summary>
        [Fact]
        public void CreateFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFeatureFlagRequest createFeatureFlagRequest = null;
            //var response = instance.CreateFeatureFlag(createFeatureFlagRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteFeatureFlag
        /// </summary>
        [Fact]
        public void DeleteFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureFlagKey = null;
            //var response = instance.DeleteFeatureFlag(featureFlagKey);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateFeatureFlag
        /// </summary>
        [Fact]
        public void UpdateFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureFlagKey = null;
            //string name = null;
            //string description = null;
            //string type = null;
            //string allowOverrideLevel = null;
            //string defaultValue = null;
            //var response = instance.UpdateFeatureFlag(featureFlagKey, name, description, type, allowOverrideLevel, defaultValue);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
