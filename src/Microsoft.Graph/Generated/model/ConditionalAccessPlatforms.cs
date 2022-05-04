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
    /// The type ConditionalAccessPlatforms.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessPlatforms>))]
    public partial class ConditionalAccessPlatforms
    {

        /// <summary>
        /// Gets or sets excludePlatforms.
        /// Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.
        /// </summary>
        [JsonPropertyName("excludePlatforms")]
        public IEnumerable<ConditionalAccessDevicePlatform> ExcludePlatforms { get; set; }
    
        /// <summary>
        /// Gets or sets includePlatforms.
        /// Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux``.
        /// </summary>
        [JsonPropertyName("includePlatforms")]
        public IEnumerable<ConditionalAccessDevicePlatform> IncludePlatforms { get; set; }
    
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
