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
    /// The type Social Identity Provider.
    /// </summary>
    public partial class SocialIdentityProvider : IdentityProviderBase
    {
    
        ///<summary>
        /// The SocialIdentityProvider constructor
        ///</summary>
        public SocialIdentityProvider()
        {
            this.ODataType = "microsoft.graph.socialIdentityProvider";
        }

        /// <summary>
        /// Gets or sets client id.
        /// The identifier for the client application obtained when registering the application with the identity provider. Required.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets client secret.
        /// The client secret for the application that is obtained when the application is registered with the identity provider. This is write-only. A read operation returns ****. Required.
        /// </summary>
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }
    
        /// <summary>
        /// Gets or sets identity provider type.
        /// For a B2B scenario, possible values: Google, Facebook. For a B2C scenario, possible values: Microsoft, Google, Amazon, LinkedIn, Facebook, GitHub, Twitter, Weibo, QQ, WeChat. Required.
        /// </summary>
        [JsonPropertyName("identityProviderType")]
        public string IdentityProviderType { get; set; }
    
    }
}

