// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Source Collection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SourceCollection : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The SourceCollection constructor
		///</summary>
        public SourceCollection()
        {
            this.ODataType = "microsoft.graph.ediscovery.sourceCollection";
        }
	
        /// <summary>
        /// Gets or sets content query.
        /// The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery.  You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date&amp;gt;=06/01/2016 AND Date&amp;lt;=07/01/2016
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentQuery", Required = Newtonsoft.Json.Required.Default)]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The user who created the sourceCollection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the sourceCollection was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets data source scopes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataSourceScopes", Required = Newtonsoft.Json.Required.Default)]
        public DataSourceScopes? DataSourceScopes { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the sourceCollection
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the sourceCollection
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// The last user who modified the sourceCollection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedBy", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The last date and time the sourceCollection was modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional sources.
        /// Adds an additional source to the sourceCollection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additionalSources", Required = Newtonsoft.Json.Required.Default)]
        public ISourceCollectionAdditionalSourcesCollectionPage AdditionalSources { get; set; }
    
        /// <summary>
        /// Gets or sets add to review set operation.
        /// Adds the results of the sourceCollection to the specified reviewSet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addToReviewSetOperation", Required = Newtonsoft.Json.Required.Default)]
        public AddToReviewSetOperation AddToReviewSetOperation { get; set; }
    
        /// <summary>
        /// Gets or sets custodian sources.
        /// Custodian sources that are included in the sourceCollection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custodianSources", Required = Newtonsoft.Json.Required.Default)]
        public ISourceCollectionCustodianSourcesCollectionWithReferencesPage CustodianSources { get; set; }
    
        /// <summary>
        /// Gets or sets last estimate statistics operation.
        /// The last estimate operation associated with the sourceCollection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastEstimateStatisticsOperation", Required = Newtonsoft.Json.Required.Default)]
        public EstimateStatisticsOperation LastEstimateStatisticsOperation { get; set; }
    
        /// <summary>
        /// Gets or sets noncustodial sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "noncustodialSources", Required = Newtonsoft.Json.Required.Default)]
        public ISourceCollectionNoncustodialSourcesCollectionWithReferencesPage NoncustodialSources { get; set; }
    
    }
}

