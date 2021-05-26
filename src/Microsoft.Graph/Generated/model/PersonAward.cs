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
    /// The type Person Award.
    /// </summary>
    public partial class PersonAward : ItemFacet
    {
    
        ///<summary>
        /// The PersonAward constructor
        ///</summary>
        public PersonAward()
        {
            this.ODataType = "microsoft.graph.personAward";
        }
    
        /// <summary>
        /// Gets or sets description.
        /// Descpription of the award or honor.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the award or honor.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets issued date.
        /// The date that the award or honor was granted.
        /// </summary>
        [JsonPropertyName("issuedDate")]
        public Date IssuedDate { get; set; }
    
        /// <summary>
        /// Gets or sets issuing authority.
        /// Authority which granted the award or honor.
        /// </summary>
        [JsonPropertyName("issuingAuthority")]
        public string IssuingAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// URL referencing a thumbnail of the award or honor.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// URL referencing the award or honor.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
    }
}

