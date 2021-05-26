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
    /// The type WindowsMinimumOperatingSystem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsMinimumOperatingSystem>))]
    public partial class WindowsMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v10_0.
        /// Windows version 10.0 or later.
        /// </summary>
        [JsonPropertyName("v10_0")]
        public bool? V10_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1607.
        /// Windows 10 1607 or later.
        /// </summary>
        [JsonPropertyName("v10_1607")]
        public bool? V10_1607 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1703.
        /// Windows 10 1703 or later.
        /// </summary>
        [JsonPropertyName("v10_1703")]
        public bool? V10_1703 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1709.
        /// Windows 10 1709 or later.
        /// </summary>
        [JsonPropertyName("v10_1709")]
        public bool? V10_1709 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1803.
        /// Windows 10 1803 or later.
        /// </summary>
        [JsonPropertyName("v10_1803")]
        public bool? V10_1803 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1809.
        /// Windows 10 1809 or later.
        /// </summary>
        [JsonPropertyName("v10_1809")]
        public bool? V10_1809 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1903.
        /// Windows 10 1903 or later.
        /// </summary>
        [JsonPropertyName("v10_1903")]
        public bool? V10_1903 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_1909.
        /// Windows 10 1909 or later.
        /// </summary>
        [JsonPropertyName("v10_1909")]
        public bool? V10_1909 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_2004.
        /// Windows 10 2004 or later.
        /// </summary>
        [JsonPropertyName("v10_2004")]
        public bool? V10_2004 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_2H20.
        /// Windows 10 2H20 or later.
        /// </summary>
        [JsonPropertyName("v10_2H20")]
        public bool? V10_2H20 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_0.
        /// Windows version 8.0 or later.
        /// </summary>
        [JsonPropertyName("v8_0")]
        public bool? V8_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_1.
        /// Windows version 8.1 or later.
        /// </summary>
        [JsonPropertyName("v8_1")]
        public bool? V8_1 { get; set; }
    
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
