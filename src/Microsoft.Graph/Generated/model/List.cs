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
    /// The type List.
    /// </summary>
    public partial class List : BaseItem
    {
    
        ///<summary>
        /// The List constructor
        ///</summary>
        public List()
        {
            this.ODataType = "microsoft.graph.list";
        }

        /// <summary>
        /// Gets or sets display name.
        /// The displayable title of the list.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets list.
        /// Provides additional details about the list.
        /// </summary>
        [JsonPropertyName("list")]
        public ListInfo ListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// </summary>
        [JsonPropertyName("sharepointIds")]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets system.
        /// If present, indicates that this is a system-managed list. Read-only.
        /// </summary>
        [JsonPropertyName("system")]
        public SystemFacet System { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// The recent activities that took place within this list.
        /// </summary>
        [JsonPropertyName("activities")]
        public IListActivitiesCollectionPage Activities { get; set; }

        /// <summary>
        /// Gets or sets activitiesNextLink.
        /// </summary>
        [JsonPropertyName("activities@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ActivitiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// </summary>
        [JsonPropertyName("columns")]
        public IListColumnsCollectionPage Columns { get; set; }

        /// <summary>
        /// Gets or sets columnsNextLink.
        /// </summary>
        [JsonPropertyName("columns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ColumnsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets content types.
        /// </summary>
        [JsonPropertyName("contentTypes")]
        public IListContentTypesCollectionPage ContentTypes { get; set; }

        /// <summary>
        /// Gets or sets contentTypesNextLink.
        /// </summary>
        [JsonPropertyName("contentTypes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ContentTypesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].
        /// </summary>
        [JsonPropertyName("drive")]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// All items contained in the list.
        /// </summary>
        [JsonPropertyName("items")]
        public IListItemsCollectionPage Items { get; set; }

        /// <summary>
        /// Gets or sets itemsNextLink.
        /// </summary>
        [JsonPropertyName("items@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ItemsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The collection of long running operations for the list.
        /// </summary>
        [JsonPropertyName("operations")]
        public IListOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptions.
        /// The set of subscriptions on the list.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public IListSubscriptionsCollectionPage Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets subscriptionsNextLink.
        /// </summary>
        [JsonPropertyName("subscriptions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SubscriptionsNextLink { get; set; }
    
    }
}

