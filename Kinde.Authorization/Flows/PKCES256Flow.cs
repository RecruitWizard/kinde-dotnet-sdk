﻿using Kinde.Authorization.Enums;
using Kinde.Authorization.Hashing;
using Kinde.Authorization.Models.Configuration;
using Kinde.Authorization.Models.Tokens;
using Kinde.Authorization.Models.User;
using Kinde.Authorization.Models.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinde.Authorization.Flows
{
    public class PKCESFlow : BaseAuthorizationFlow<PKCEConfiguration<SHA256CodeVerifier>>, IAuthorizationFlow
    {
        public PKCESFlow(IClientConfiguration clientConfiguration, PKCEConfiguration<SHA256CodeVerifier> configuration) : base(clientConfiguration, configuration)
        {
        }

        public override IUserActionResolver UserActionsResolver { get; init; } = new PKCEUserActionResolver<SHA256CodeVerifier>();

        public override async Task<AuthotizationStates> Authorize(HttpClient httpClient)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("response_type", "code");
            parameters.Add("grant_type", "authorization_code");
            parameters.Add("client_id", Configuration.ClientId);
            parameters.Add("redirect_uri", ClientConfiguration.ReplyUrl);
            parameters.Add("scope", Configuration.Scope);
            parameters.Add("client_secret", Configuration.ClientSecret);
            parameters.Add("code_challenge", await Configuration.CodeVerifier.Compute(Configuration.State));
            parameters.Add("code_challenge_method", "S256");
            var response = await httpClient.PostAsync(ClientConfiguration.Domain + "/oauth2/auth", BuildContent(parameters));
            if (response.Headers.Location != null)
            {

                await UserActionsResolver.SetLoginUrl(ClientConfiguration.Domain + response.Headers.Location.ToString(), Configuration.State);
                KindeClient.CodeStore.ItemAdded += CodeStore_ItemAdded;
                AuthotizationState = AuthotizationStates.UserActionsNeeded;
                return AuthotizationState;
            }
            else
            {
                throw new ApplicationException(await response.Content.ReadAsStringAsync());
            }
        }

        private async void CodeStore_ItemAdded(object? sender, Models.Utils.ItemAddedEventArgs<string, string> e)
        {
            if (e.Key != Configuration.State) return;
            await OnCodeRecieved(e.Key, e.Value);
        }
        public async Task OnCodeRecieved(string state, string code)
        {
            var httpClient = new Kinde.Authorization.Models.KindeHttpClient();
            var parameters = new Dictionary<string, string>();

            parameters.Add("grant_type", "authorization_code");
            parameters.Add("client_id", Configuration.ClientId);
            parameters.Add("client_secret", Configuration.ClientSecret);
            parameters.Add("scope", Configuration.Scope);
            parameters.Add("code", code);
            parameters.Add("code_verifier", state);
            parameters.Add("redirect_uri", ClientConfiguration.ReplyUrl);

            var response = await httpClient.PostAsync(ClientConfiguration.Domain + "/oauth2/token", BuildContent(parameters));
            if ((int)response.StatusCode < 400)
            {
                var tokenString = await response.Content.ReadAsStringAsync();
                Token = JsonConvert.DeserializeObject<OauthToken>(tokenString);
                AuthotizationState = AuthotizationStates.Authorized;
            }
            else
            {
                throw new ApplicationException(await response.Content.ReadAsStringAsync());
            }



        }
    }
}
