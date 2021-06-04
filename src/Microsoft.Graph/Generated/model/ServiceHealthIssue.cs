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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Service Health Issue.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ServiceHealthIssue : ServiceAnnouncementBase
    {
    
		///<summary>
		/// The ServiceHealthIssue constructor
		///</summary>
        public ServiceHealthIssue()
        {
            this.ODataType = "microsoft.graph.serviceHealthIssue";
        }
	
        /// <summary>
        /// Gets or sets classification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classification", Required = Newtonsoft.Json.Required.Default)]
        public ServiceHealthClassificationType? Classification { get; set; }
    
        /// <summary>
        /// Gets or sets feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feature", Required = Newtonsoft.Json.Required.Default)]
        public string Feature { get; set; }
    
        /// <summary>
        /// Gets or sets feature group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureGroup", Required = Newtonsoft.Json.Required.Default)]
        public string FeatureGroup { get; set; }
    
        /// <summary>
        /// Gets or sets impact description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "impactDescription", Required = Newtonsoft.Json.Required.Default)]
        public string ImpactDescription { get; set; }
    
        /// <summary>
        /// Gets or sets is resolved.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isResolved", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsResolved { get; set; }
    
        /// <summary>
        /// Gets or sets origin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "origin", Required = Newtonsoft.Json.Required.Default)]
        public ServiceHealthOrigin? Origin { get; set; }
    
        /// <summary>
        /// Gets or sets posts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ServiceHealthIssuePost> Posts { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service", Required = Newtonsoft.Json.Required.Default)]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ServiceHealthStatus? Status { get; set; }
    
    }
}

