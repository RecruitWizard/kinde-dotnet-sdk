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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest? createUserRequest = null;
            //var response = instance.CreateUser(createUserRequest);
            //Assert.IsType<CreateUserResponse>(response);
        }

        /// <summary>
        /// Test CreateUserIdentity
        /// </summary>
        [Fact]
        public void CreateUserIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //CreateUserIdentityRequest? createUserIdentityRequest = null;
            //var response = instance.CreateUserIdentity(userId, createUserIdentityRequest);
            //Assert.IsType<CreateIdentityResponse>(response);
        }

        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Fact]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? isDeleteProfile = null;
            //var response = instance.DeleteUser(id, isDeleteProfile);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteUserSessions
        /// </summary>
        [Fact]
        public void DeleteUserSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.DeleteUserSessions(userId);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetUserData
        /// </summary>
        [Fact]
        public void GetUserDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? expand = null;
            //var response = instance.GetUserData(id, expand);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetUserIdentities
        /// </summary>
        [Fact]
        public void GetUserIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string? startingAfter = null;
            //string? endingBefore = null;
            //var response = instance.GetUserIdentities(userId, startingAfter, endingBefore);
            //Assert.IsType<GetIdentitiesResponse>(response);
        }

        /// <summary>
        /// Test GetUserPropertyValues
        /// </summary>
        [Fact]
        public void GetUserPropertyValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.GetUserPropertyValues(userId);
            //Assert.IsType<GetPropertyValuesResponse>(response);
        }

        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Fact]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageSize = null;
            //string? userId = null;
            //string? nextToken = null;
            //string? email = null;
            //string? username = null;
            //string? expand = null;
            //bool? hasOrganization = null;
            //var response = instance.GetUsers(pageSize, userId, nextToken, email, username, expand, hasOrganization);
            //Assert.IsType<UsersResponse>(response);
        }

        /// <summary>
        /// Test GetUsersMFA
        /// </summary>
        [Fact]
        public void GetUsersMFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.GetUsersMFA(userId);
            //Assert.IsType<GetUserMfaResponse>(response);
        }

        /// <summary>
        /// Test RefreshUserClaims
        /// </summary>
        [Fact]
        public void RefreshUserClaimsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.RefreshUserClaims(userId);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test ResetUsersMFA
        /// </summary>
        [Fact]
        public void ResetUsersMFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string factorId = null;
            //var response = instance.ResetUsersMFA(userId, factorId);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test SetUserPassword
        /// </summary>
        [Fact]
        public void SetUserPasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //SetUserPasswordRequest setUserPasswordRequest = null;
            //var response = instance.SetUserPassword(userId, setUserPasswordRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UpdateUserRequest updateUserRequest = null;
            //var response = instance.UpdateUser(id, updateUserRequest);
            //Assert.IsType<UpdateUserResponse>(response);
        }

        /// <summary>
        /// Test UpdateUserFeatureFlagOverride
        /// </summary>
        [Fact]
        public void UpdateUserFeatureFlagOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string featureFlagKey = null;
            //string value = null;
            //var response = instance.UpdateUserFeatureFlagOverride(userId, featureFlagKey, value);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateUserProperties
        /// </summary>
        [Fact]
        public void UpdateUserPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //UpdateOrganizationPropertiesRequest updateOrganizationPropertiesRequest = null;
            //var response = instance.UpdateUserProperties(userId, updateOrganizationPropertiesRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateUserProperty
        /// </summary>
        [Fact]
        public void UpdateUserPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string propertyKey = null;
            //string value = null;
            //var response = instance.UpdateUserProperty(userId, propertyKey, value);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
