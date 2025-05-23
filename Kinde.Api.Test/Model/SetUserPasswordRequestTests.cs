/*
 * Kinde Management API
 *
 *  Provides endpoints to manage your Kinde Businesses.  ## Intro  ## How to use  1. [Set up and authorize a machine-to-machine (M2M) application](https://docs.kinde.com/developer-tools/kinde-api/connect-to-kinde-api/).  2. [Generate a test access token](https://docs.kinde.com/developer-tools/kinde-api/access-token-for-api/)  3. Test request any endpoint using the test token 
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Kinde.Api.Model;
using Kinde.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Kinde.Api.Test.Model
{
    /// <summary>
    ///  Class for testing SetUserPasswordRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SetUserPasswordRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SetUserPasswordRequest
        //private SetUserPasswordRequest instance;

        public SetUserPasswordRequestTests()
        {
            // TODO uncomment below to create an instance of SetUserPasswordRequest
            //instance = new SetUserPasswordRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SetUserPasswordRequest
        /// </summary>
        [Fact]
        public void SetUserPasswordRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SetUserPasswordRequest
            //Assert.IsType<SetUserPasswordRequest>(instance);
        }

        /// <summary>
        /// Test the property 'HashedPassword'
        /// </summary>
        [Fact]
        public void HashedPasswordTest()
        {
            // TODO unit test for the property 'HashedPassword'
        }

        /// <summary>
        /// Test the property 'HashingMethod'
        /// </summary>
        [Fact]
        public void HashingMethodTest()
        {
            // TODO unit test for the property 'HashingMethod'
        }

        /// <summary>
        /// Test the property 'Salt'
        /// </summary>
        [Fact]
        public void SaltTest()
        {
            // TODO unit test for the property 'Salt'
        }

        /// <summary>
        /// Test the property 'SaltPosition'
        /// </summary>
        [Fact]
        public void SaltPositionTest()
        {
            // TODO unit test for the property 'SaltPosition'
        }

        /// <summary>
        /// Test the property 'IsTemporaryPassword'
        /// </summary>
        [Fact]
        public void IsTemporaryPasswordTest()
        {
            // TODO unit test for the property 'IsTemporaryPassword'
        }
    }
}
