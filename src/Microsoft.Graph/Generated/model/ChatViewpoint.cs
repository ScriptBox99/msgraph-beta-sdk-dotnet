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
    /// The type ChatViewpoint.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatViewpoint>))]
    public partial class ChatViewpoint
    {

        /// <summary>
        /// Gets or sets lastMessageReadDateTime.
        /// Represents the dateTime up until which the calling user has read chatMessages in a specific chat.
        /// </summary>
        [JsonPropertyName("lastMessageReadDateTime")]
        public DateTimeOffset? LastMessageReadDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
