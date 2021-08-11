// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Updatable Asset Group.
    /// </summary>
    public partial class UpdatableAssetGroup : UpdatableAsset
    {
    
        ///<summary>
        /// The UpdatableAssetGroup constructor
        ///</summary>
        public UpdatableAssetGroup()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.updatableAssetGroup";
        }

        /// <summary>
        /// Gets or sets members.
        /// Members of the group. Read-only.
        /// </summary>
        [JsonPropertyName("members")]
        public IUpdatableAssetGroupMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
    }
}

