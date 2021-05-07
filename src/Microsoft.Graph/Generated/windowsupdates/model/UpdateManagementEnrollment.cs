// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UpdateManagementEnrollment.
    /// </summary>
    public partial class UpdateManagementEnrollment : UpdatableAssetEnrollment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagementEnrollment"/> class.
        /// </summary>
        public UpdateManagementEnrollment()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.updateManagementEnrollment";
        }

        /// <summary>
        /// Gets or sets updateCategory.
        /// The category of updates that the service manages. Supports a subset of the values for updateCategory. Possible values are: feature.
        /// </summary>
        [JsonPropertyName("updateCategory")]
        public UpdateCategory? UpdateCategory { get; set; }
    
    }
}
