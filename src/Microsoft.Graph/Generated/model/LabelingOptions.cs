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
    /// The type LabelingOptions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<LabelingOptions>))]
    public partial class LabelingOptions
    {

        /// <summary>
        /// Gets or sets assignmentMethod.
        /// Possible values are: standard, privileged, auto.
        /// </summary>
        [JsonPropertyName("assignmentMethod")]
        public AssignmentMethod? AssignmentMethod { get; set; }
    
        /// <summary>
        /// Gets or sets downgradeJustification.
        /// The downgrade justification object that indicates if downgrade was justified and, if so, the reason.
        /// </summary>
        [JsonPropertyName("downgradeJustification")]
        public DowngradeJustification DowngradeJustification { get; set; }
    
        /// <summary>
        /// Gets or sets extendedProperties.
        /// Extended properties will be parsed and returned in the standard MIP labeled metadata format as part of the label information.
        /// </summary>
        [JsonPropertyName("extendedProperties")]
        public IEnumerable<KeyValuePair> ExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets labelId.
        /// The GUID of the label that should be applied to the information.
        /// </summary>
        [JsonPropertyName("labelId")]
        public Guid? LabelId { get; set; }
    
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
