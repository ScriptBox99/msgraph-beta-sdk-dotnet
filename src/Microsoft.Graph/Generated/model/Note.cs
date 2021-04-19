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
    /// The type Note.
    /// </summary>
    public partial class Note : OutlookItem
    {
    
		///<summary>
		/// The Note constructor
		///</summary>
        public Note()
        {
            this.ODataType = "microsoft.graph.note";
        }
	
        /// <summary>
        /// Gets or sets body.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// </summary>
        [JsonPropertyName("attachments")]
        public INoteAttachmentsCollectionPage Attachments { get; set; }

        /// <summary>
        /// Gets or sets attachmentsNextLink.
        /// </summary>
        [JsonPropertyName("attachments@odata.nextLink")]
        public string AttachmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonPropertyName("extensions")]
        public INoteExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public INoteMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public INoteSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

