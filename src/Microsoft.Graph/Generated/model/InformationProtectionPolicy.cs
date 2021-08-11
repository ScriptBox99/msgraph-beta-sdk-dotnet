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
    /// The type Information Protection Policy.
    /// </summary>
    public partial class InformationProtectionPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public IInformationProtectionPolicyLabelsCollectionPage Labels { get; set; }

        /// <summary>
        /// Gets or sets labelsNextLink.
        /// </summary>
        [JsonPropertyName("labels@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string LabelsNextLink { get; set; }
    
    }
}

