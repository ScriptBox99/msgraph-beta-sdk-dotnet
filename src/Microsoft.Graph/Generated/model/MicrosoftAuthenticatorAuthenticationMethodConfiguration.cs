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
    /// The type Microsoft Authenticator Authentication Method Configuration.
    /// </summary>
    public partial class MicrosoftAuthenticatorAuthenticationMethodConfiguration : AuthenticationMethodConfiguration
    {
    
        ///<summary>
        /// The MicrosoftAuthenticatorAuthenticationMethodConfiguration constructor
        ///</summary>
        public MicrosoftAuthenticatorAuthenticationMethodConfiguration()
        {
            this.ODataType = "microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration";
        }

        /// <summary>
        /// Gets or sets include targets.
        /// A collection of users or groups who are enabled to use the authentication method.
        /// </summary>
        [Obsolete("")]
        [JsonPropertyName("includeTargets")]
        public IMicrosoftAuthenticatorAuthenticationMethodConfigurationIncludeTargetsCollectionPage IncludeTargets { get; set; }

        /// <summary>
        /// Gets or sets includeTargetsNextLink.
        /// </summary>
        [JsonPropertyName("includeTargets@odata.nextLink")]
        public string IncludeTargetsNextLink { get; set; }
    
    }
}

