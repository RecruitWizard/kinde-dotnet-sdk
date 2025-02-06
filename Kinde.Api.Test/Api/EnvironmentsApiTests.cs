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
    ///  Class for testing EnvironmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnvironmentsApiTests : IDisposable
    {
        private EnvironmentsApi instance;

        public EnvironmentsApiTests()
        {
            instance = new EnvironmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EnvironmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EnvironmentsApi
            //Assert.IsType<EnvironmentsApi>(instance);
        }

        /// <summary>
        /// Test DeleteEnvironementFeatureFlagOverride
        /// </summary>
        [Fact]
        public void DeleteEnvironementFeatureFlagOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureFlagKey = null;
            //var response = instance.DeleteEnvironementFeatureFlagOverride(featureFlagKey);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteEnvironementFeatureFlagOverrides
        /// </summary>
        [Fact]
        public void DeleteEnvironementFeatureFlagOverridesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeleteEnvironementFeatureFlagOverrides();
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetEnvironementFeatureFlags
        /// </summary>
        [Fact]
        public void GetEnvironementFeatureFlagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnvironementFeatureFlags();
            //Assert.IsType<GetEnvironmentFeatureFlagsResponse>(response);
        }

        /// <summary>
        /// Test GetEnvironment
        /// </summary>
        [Fact]
        public void GetEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnvironment();
            //Assert.IsType<GetEnvironmentResponse>(response);
        }

        /// <summary>
        /// Test UpdateEnvironementFeatureFlagOverride
        /// </summary>
        [Fact]
        public void UpdateEnvironementFeatureFlagOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureFlagKey = null;
            //UpdateEnvironementFeatureFlagOverrideRequest updateEnvironementFeatureFlagOverrideRequest = null;
            //var response = instance.UpdateEnvironementFeatureFlagOverride(featureFlagKey, updateEnvironementFeatureFlagOverrideRequest);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
