// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Store.
    /// </summary>
    public partial class Store : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The Store constructor
		///</summary>
        public Store()
        {
            this.ODataType = "microsoft.graph.termStore.store";
        }
	
        /// <summary>
        /// Gets or sets default language tag.
        /// Default language of the term store.
        /// </summary>
        [JsonPropertyName("defaultLanguageTag")]
        public string DefaultLanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets language tags.
        /// List of languages for the term store.
        /// </summary>
        [JsonPropertyName("languageTags")]
        public IEnumerable<string> LanguageTags { get; set; }
    
        /// <summary>
        /// Gets or sets groups.
        /// Collection of all groups available in the term store.
        /// </summary>
        [JsonPropertyName("groups")]
        public IStoreGroupsCollectionPage Groups { get; set; }

        /// <summary>
        /// Gets or sets groupsNextLink.
        /// </summary>
        [JsonPropertyName("groups@odata.nextLink")]
        public string GroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sets.
        /// Collection of all sets available in the term store.
        /// </summary>
        [JsonPropertyName("sets")]
        public IStoreSetsCollectionPage Sets { get; set; }

        /// <summary>
        /// Gets or sets setsNextLink.
        /// </summary>
        [JsonPropertyName("sets@odata.nextLink")]
        public string SetsNextLink { get; set; }
    
    }
}

