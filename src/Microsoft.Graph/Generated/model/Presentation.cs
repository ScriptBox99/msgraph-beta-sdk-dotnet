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
    /// The type Presentation.
    /// </summary>
    public partial class Presentation : Entity
    {
    
        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [JsonPropertyName("comments")]
        public IPresentationCommentsCollectionPage Comments { get; set; }

        /// <summary>
        /// Gets or sets commentsNextLink.
        /// </summary>
        [JsonPropertyName("comments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CommentsNextLink { get; set; }
    
    }
}

