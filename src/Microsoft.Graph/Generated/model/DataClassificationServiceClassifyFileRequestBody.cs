// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DataClassificationServiceClassifyFileRequestBody.
    /// </summary>
    public partial class DataClassificationServiceClassifyFileRequestBody
    {
    
        /// <summary>
        /// Gets or sets File.
        /// </summary>
        [JsonPropertyName("file")]
        public Stream File { get; set; }
    
        /// <summary>
        /// Gets or sets SensitiveTypeIds.
        /// </summary>
        [JsonPropertyName("sensitiveTypeIds")]
        public IEnumerable<string> SensitiveTypeIds { get; set; }
    
    }
}
