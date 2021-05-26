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
    /// The type Permission Grant Policy.
    /// </summary>
    public partial class PermissionGrantPolicy : PolicyBase
    {
    
        ///<summary>
        /// The PermissionGrantPolicy constructor
        ///</summary>
        public PermissionGrantPolicy()
        {
            this.ODataType = "microsoft.graph.permissionGrantPolicy";
        }
    
        /// <summary>
        /// Gets or sets excludes.
        /// Condition sets which are excluded in this permission grant policy. Automatically expanded on GET.
        /// </summary>
        [JsonPropertyName("excludes")]
        public IPermissionGrantPolicyExcludesCollectionPage Excludes { get; set; }

        /// <summary>
        /// Gets or sets excludesNextLink.
        /// </summary>
        [JsonPropertyName("excludes@odata.nextLink")]
        public string ExcludesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets includes.
        /// Condition sets which are included in this permission grant policy. Automatically expanded on GET.
        /// </summary>
        [JsonPropertyName("includes")]
        public IPermissionGrantPolicyIncludesCollectionPage Includes { get; set; }

        /// <summary>
        /// Gets or sets includesNextLink.
        /// </summary>
        [JsonPropertyName("includes@odata.nextLink")]
        public string IncludesNextLink { get; set; }
    
    }
}

