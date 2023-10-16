/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Kinde.Api.Client.FileParameter;
using OpenAPIDateConverter = Kinde.Api.Client.OpenAPIDateConverter;

namespace Kinde.Api.Model
{
    /// <summary>
    /// UpdateApplicationRequest
    /// </summary>
    [DataContract(Name = "updateApplication_request")]
    public partial class UpdateApplicationRequest : IEquatable<UpdateApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationRequest" /> class.
        /// </summary>
        /// <param name="name">The application&#39;s name..</param>
        /// <param name="languageKey">The application&#39;s language key..</param>
        /// <param name="logoutUris">The application&#39;s logout uris..</param>
        /// <param name="redirectUris">The application&#39;s redirect uris..</param>
        public UpdateApplicationRequest(string name = default(string), string languageKey = default(string), List<string> logoutUris = default(List<string>), List<string> redirectUris = default(List<string>))
        {
            this.Name = name;
            this.LanguageKey = languageKey;
            this.LogoutUris = logoutUris;
            this.RedirectUris = redirectUris;
        }

        /// <summary>
        /// The application&#39;s name.
        /// </summary>
        /// <value>The application&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The application&#39;s language key.
        /// </summary>
        /// <value>The application&#39;s language key.</value>
        [DataMember(Name = "language_key", EmitDefaultValue = false)]
        public string LanguageKey { get; set; }

        /// <summary>
        /// The application&#39;s logout uris.
        /// </summary>
        /// <value>The application&#39;s logout uris.</value>
        [DataMember(Name = "logout_uris", EmitDefaultValue = false)]
        public List<string> LogoutUris { get; set; }

        /// <summary>
        /// The application&#39;s redirect uris.
        /// </summary>
        /// <value>The application&#39;s redirect uris.</value>
        [DataMember(Name = "redirect_uris", EmitDefaultValue = false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateApplicationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LanguageKey: ").Append(LanguageKey).Append("\n");
            sb.Append("  LogoutUris: ").Append(LogoutUris).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateApplicationRequest);
        }

        /// <summary>
        /// Returns true if UpdateApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LanguageKey == input.LanguageKey ||
                    (this.LanguageKey != null &&
                    this.LanguageKey.Equals(input.LanguageKey))
                ) && 
                (
                    this.LogoutUris == input.LogoutUris ||
                    this.LogoutUris != null &&
                    input.LogoutUris != null &&
                    this.LogoutUris.SequenceEqual(input.LogoutUris)
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LanguageKey != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageKey.GetHashCode();
                }
                if (this.LogoutUris != null)
                {
                    hashCode = (hashCode * 59) + this.LogoutUris.GetHashCode();
                }
                if (this.RedirectUris != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUris.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
