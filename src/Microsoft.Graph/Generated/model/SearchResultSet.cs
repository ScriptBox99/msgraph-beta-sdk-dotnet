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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SearchResultSet.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SearchResultSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultSet"/> class.
        /// </summary>
        public SearchResultSet()
        {
            this.ODataType = "microsoft.graph.searchResultSet";
        }

        /// <summary>
        /// Gets or sets hitsContainers.
        /// A collection of search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hitsContainers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SearchHitsContainer> HitsContainers { get; set; }
    
        /// <summary>
        /// Gets or sets resultTemplates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resultTemplates", Required = Newtonsoft.Json.Required.Default)]
        public ResultTemplateDictionary ResultTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets searchTerms.
        /// Contains the search terms sent in the initial search query.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "searchTerms", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SearchTerms { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
