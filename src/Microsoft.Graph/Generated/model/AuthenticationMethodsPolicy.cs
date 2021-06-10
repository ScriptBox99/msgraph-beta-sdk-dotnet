// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Authentication Methods Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AuthenticationMethodsPolicy : Entity
    {
    
		///<summary>
		/// The AuthenticationMethodsPolicy constructor
		///</summary>
        public AuthenticationMethodsPolicy()
        {
            this.ODataType = "microsoft.graph.authenticationMethodsPolicy";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// A description of the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time of the last update to the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets policy version.
        /// The version of the policy in use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyVersion", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyVersion { get; set; }
    
        /// <summary>
        /// Gets or sets reconfirmation in days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reconfirmationInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ReconfirmationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets registration enforcement.
        /// Enforce registration at sign-in time. This property can be used to remind users to set up targeted authentication methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registrationEnforcement", Required = Newtonsoft.Json.Required.Default)]
        public RegistrationEnforcement RegistrationEnforcement { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method configurations.
        /// Represents the settings for each authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethodConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IAuthenticationMethodsPolicyAuthenticationMethodConfigurationsCollectionPage AuthenticationMethodConfigurations { get; set; }
    
    }
}

