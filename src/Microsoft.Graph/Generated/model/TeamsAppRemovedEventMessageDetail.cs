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
    /// The type TeamsAppRemovedEventMessageDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsAppRemovedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAppRemovedEventMessageDetail"/> class.
        /// </summary>
        public TeamsAppRemovedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.teamsAppRemovedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets initiator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiator", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Initiator { get; set; }
    
        /// <summary>
        /// Gets or sets teamsAppDisplayName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsAppDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string TeamsAppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets teamsAppId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsAppId", Required = Newtonsoft.Json.Required.Default)]
        public string TeamsAppId { get; set; }
    
    }
}
