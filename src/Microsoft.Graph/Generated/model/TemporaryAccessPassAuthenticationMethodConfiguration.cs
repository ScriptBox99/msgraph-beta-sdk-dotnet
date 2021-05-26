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
    /// The type Temporary Access Pass Authentication Method Configuration.
    /// </summary>
    public partial class TemporaryAccessPassAuthenticationMethodConfiguration : AuthenticationMethodConfiguration
    {
    
        ///<summary>
        /// The TemporaryAccessPassAuthenticationMethodConfiguration constructor
        ///</summary>
        public TemporaryAccessPassAuthenticationMethodConfiguration()
        {
            this.ODataType = "microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration";
        }
    
        /// <summary>
        /// Gets or sets default length.
        /// </summary>
        [JsonPropertyName("defaultLength")]
        public Int32? DefaultLength { get; set; }
    
        /// <summary>
        /// Gets or sets default lifetime in minutes.
        /// </summary>
        [JsonPropertyName("defaultLifetimeInMinutes")]
        public Int32? DefaultLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets is usable once.
        /// </summary>
        [JsonPropertyName("isUsableOnce")]
        public bool? IsUsableOnce { get; set; }
    
        /// <summary>
        /// Gets or sets maximum lifetime in minutes.
        /// </summary>
        [JsonPropertyName("maximumLifetimeInMinutes")]
        public Int32? MaximumLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets minimum lifetime in minutes.
        /// </summary>
        [JsonPropertyName("minimumLifetimeInMinutes")]
        public Int32? MinimumLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets include targets.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public ITemporaryAccessPassAuthenticationMethodConfigurationIncludeTargetsCollectionPage IncludeTargets { get; set; }

        /// <summary>
        /// Gets or sets includeTargetsNextLink.
        /// </summary>
        [JsonPropertyName("includeTargets@odata.nextLink")]
        public string IncludeTargetsNextLink { get; set; }
    
    }
}

