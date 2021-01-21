// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type NoteSingleValueExtendedPropertiesCollectionResponse.
    /// </summary>
    public class NoteSingleValueExtendedPropertiesCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="INoteSingleValueExtendedPropertiesCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public INoteSingleValueExtendedPropertiesCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
