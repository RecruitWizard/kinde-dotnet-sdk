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
    ///  Class for testing GetRolesResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetRolesResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetRolesResponse
        //private GetRolesResponse instance;

        public GetRolesResponseTests()
        {
            // TODO uncomment below to create an instance of GetRolesResponse
            //instance = new GetRolesResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetRolesResponse
        /// </summary>
        [Fact]
        public void GetRolesResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetRolesResponse
            //Assert.IsType<GetRolesResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'Roles'
        /// </summary>
        [Fact]
        public void RolesTest()
        {
            // TODO unit test for the property 'Roles'
        }

        /// <summary>
        /// Test the property 'NextToken'
        /// </summary>
        [Fact]
        public void NextTokenTest()
        {
            // TODO unit test for the property 'NextToken'
        }
    }
}
