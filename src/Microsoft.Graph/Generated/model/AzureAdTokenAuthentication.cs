// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AzureAdTokenAuthentication.
    /// </summary>
    public partial class AzureAdTokenAuthentication : CustomExtensionAuthenticationConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureAdTokenAuthentication"/> class.
        /// </summary>
        public AzureAdTokenAuthentication()
        {
            this.ODataType = "microsoft.graph.azureAdTokenAuthentication";
        }

        /// <summary>
        /// Gets or sets resourceId.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
    }
}
