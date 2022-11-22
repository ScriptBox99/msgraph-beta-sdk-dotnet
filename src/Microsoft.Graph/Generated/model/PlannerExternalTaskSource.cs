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
    /// The type PlannerExternalTaskSource.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerExternalTaskSource>))]
    public partial class PlannerExternalTaskSource : PlannerTaskCreation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerExternalTaskSource"/> class.
        /// </summary>
        public PlannerExternalTaskSource()
        {
            this.ODataType = "microsoft.graph.plannerExternalTaskSource";
        }

        /// <summary>
        /// Gets or sets contextScenarioId.
        /// </summary>
        [JsonPropertyName("contextScenarioId")]
        public string ContextScenarioId { get; set; }
    
        /// <summary>
        /// Gets or sets displayLinkType.
        /// </summary>
        [JsonPropertyName("displayLinkType")]
        public PlannerExternalTaskSourceDisplayType? DisplayLinkType { get; set; }
    
        /// <summary>
        /// Gets or sets displayNameSegments.
        /// </summary>
        [JsonPropertyName("displayNameSegments")]
        public IEnumerable<string> DisplayNameSegments { get; set; }
    
        /// <summary>
        /// Gets or sets externalContextId.
        /// </summary>
        [JsonPropertyName("externalContextId")]
        public string ExternalContextId { get; set; }
    
        /// <summary>
        /// Gets or sets externalObjectId.
        /// </summary>
        [JsonPropertyName("externalObjectId")]
        public string ExternalObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets externalObjectVersion.
        /// </summary>
        [JsonPropertyName("externalObjectVersion")]
        public string ExternalObjectVersion { get; set; }
    
        /// <summary>
        /// Gets or sets webUrl.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
    }
}
