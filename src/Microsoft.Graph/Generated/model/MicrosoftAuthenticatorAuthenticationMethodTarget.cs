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
    /// The type Microsoft Authenticator Authentication Method Target.
    /// </summary>
    [Obsolete("")]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MicrosoftAuthenticatorAuthenticationMethodTarget : AuthenticationMethodTarget
    {
    
		///<summary>
		/// The MicrosoftAuthenticatorAuthenticationMethodTarget constructor
		///</summary>
        public MicrosoftAuthenticatorAuthenticationMethodTarget()
        {
            this.ODataType = "microsoft.graph.microsoftAuthenticatorAuthenticationMethodTarget";
        }
	
        /// <summary>
        /// Gets or sets authentication mode.
        /// Determines which types of notifications can be used for sign-in. Possible values are: any, deviceBasedPush (passwordless only), push.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMode", Required = Newtonsoft.Json.Required.Default)]
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode { get; set; }
    
        /// <summary>
        /// Gets or sets feature settings.
        /// Determines what additional settings should be applied to Microsoft Authenticator. Possible values are: null, requireNumberMatching (Requires number matching for MFA notifications. Value is ignored for phone sign-in notifications).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureSettings", Required = Newtonsoft.Json.Required.Default)]
        public AuthenticatorAppFeatureSettings? FeatureSettings { get; set; }
    
    }
}

