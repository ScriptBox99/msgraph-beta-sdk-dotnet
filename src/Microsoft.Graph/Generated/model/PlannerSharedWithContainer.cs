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
    /// The type PlannerSharedWithContainer.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerSharedWithContainer>))]
    public partial class PlannerSharedWithContainer : PlannerPlanContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerSharedWithContainer"/> class.
        /// </summary>
        public PlannerSharedWithContainer()
        {
            this.ODataType = "microsoft.graph.plannerSharedWithContainer";
        }

        /// <summary>
        /// Gets or sets accessLevel.
        /// </summary>
        [JsonPropertyName("accessLevel")]
        public PlannerPlanAccessLevel? AccessLevel { get; set; }
    
    }
}
