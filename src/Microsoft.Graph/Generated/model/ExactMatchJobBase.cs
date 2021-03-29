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
    /// The type Exact Match Job Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ExactMatchJobBase>))]
    public partial class ExactMatchJobBase : Entity
    {
    
		///<summary>
		/// The internal ExactMatchJobBase constructor
		///</summary>
        protected internal ExactMatchJobBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets completion date time.
        /// </summary>
        [JsonPropertyName("completionDateTime")]
        public DateTimeOffset? CompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// </summary>
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonPropertyName("error")]
        public ClassificationError Error { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// </summary>
        [JsonPropertyName("lastUpdatedDateTime")]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
    }
}

