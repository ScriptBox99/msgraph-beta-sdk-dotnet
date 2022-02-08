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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Microsoft Authenticator Authentication Method Target.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MicrosoftAuthenticatorAuthenticationMethodTarget>))]
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
        [JsonPropertyName("authenticationMode")]
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode { get; set; }
    
        /// <summary>
        /// Gets or sets display app information required state.
        /// Determines whether the user is shown additional context in their Authenticator app notification. In the body of the Authenticator notification, the user will be shown the app they are signing into along with the location that the authentication request originated from. Possible values are: enabled, disabled, default.
        /// </summary>
        [JsonPropertyName("displayAppInformationRequiredState")]
        public AdvancedConfigState? DisplayAppInformationRequiredState { get; set; }
    
        /// <summary>
        /// Gets or sets number matching required state.
        /// Requires number matching for MFA notifications. Value is ignored for phone sign-in notifications. Possible values are: enabled, disabled, default.
        /// </summary>
        [JsonPropertyName("numberMatchingRequiredState")]
        public AdvancedConfigState? NumberMatchingRequiredState { get; set; }
    
    }
}

