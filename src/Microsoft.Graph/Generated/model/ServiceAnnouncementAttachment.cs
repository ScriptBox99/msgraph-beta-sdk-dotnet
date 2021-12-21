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
    /// The type Service Announcement Attachment.
    /// </summary>
    public partial class ServiceAnnouncementAttachment : Entity
    {
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [JsonPropertyName("size")]
        public Int32? Size { get; set; }
    
    }
}

