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
    /// CreateSubscriberSuccessResponse
    /// </summary>
    [DataContract(Name = "create_subscriber_success_response")]
    public partial class CreateSubscriberSuccessResponse : IEquatable<CreateSubscriberSuccessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriberSuccessResponse" /> class.
        /// </summary>
        /// <param name="subscriber">subscriber.</param>
        public CreateSubscriberSuccessResponse(CreateSubscriberSuccessResponseSubscriber subscriber = default(CreateSubscriberSuccessResponseSubscriber))
        {
            this.Subscriber = subscriber;
        }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public CreateSubscriberSuccessResponseSubscriber Subscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriberSuccessResponse {\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
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
            return this.Equals(input as CreateSubscriberSuccessResponse);
        }

        /// <summary>
        /// Returns true if CreateSubscriberSuccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriberSuccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriberSuccessResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
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
                if (this.Subscriber != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriber.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
